using System.IO.Pipes;

namespace PhantomCube
{
    public partial class FormMain : Form
    {
        public NamedPipeServerStream? pipeServPhantomToMilla;
        StreamWriter? writer;

        public NamedPipeServerStream? pipeServPhantomFromMilla;
        StreamReader? reader;

        FormWarpAdvanced? frmWarpAdvanced;

        public IAsyncResult? asyncResultToMilla;
        public IAsyncResult? asyncResultFromMilla;
        public Task? taskResultToMilla;
        public Task? taskResultFromMilla;
        public bool requestedInitValues = false;
        
        public List<string> messagesReceived;
        
        public List<string> DebugLines = new List<string>();
        public int MaxDebugLines = 100;
        private bool shutdown = false;

        public FormMain()
        {
            InitializeComponent();
            messagesReceived = new List<string>();
        }

        private void btnSendDebugMessage_Click(object sender, EventArgs e)
        {
            SendTextThroughPipe("DREADBOX");
        }

        private void lblSpawnSpeed_Click(object sender, EventArgs e)
        {

        }

        private void btnSetSpawnVelocity_Click(object sender, EventArgs e)
        {
            SendTextThroughPipe("spawn_velocity," + txtSpawnVelocity.Text);
        }

        public bool SendTextThroughPipe(string text)
        {
            bool success = true;
            if (pipeServPhantomToMilla == null)
            {
                pipeServPhantomToMilla = new NamedPipeServerStream("RSNPhantomToMilla");
                //asyncResultToMilla = pipeServPhantomToMilla.BeginWaitForConnection(null, null);
                taskResultToMilla = pipeServPhantomToMilla.WaitForConnectionAsync();
            }
            if (!pipeServPhantomToMilla.IsConnected)
            {
                /*
                var failed = false;
                try { pipeServPhantomToMilla.Connect(100); }
                catch { failed = true; }
                if (failed) { return; }
                */
                success = false;
                return success;
            }
            if (writer == null)
            {
                writer = new StreamWriter(pipeServPhantomToMilla);
            }
            writer.WriteLine(text);
            writer.Flush();

            AddDebugLine("Sent: " + text);
            return success;
        }

        public void ThreadReadMessagesFromPipe()
        {
            while (!shutdown)
            {
                if (pipeServPhantomFromMilla == null)
                {
                    pipeServPhantomFromMilla = new NamedPipeServerStream("RSNPhantomFromMilla");
                    taskResultFromMilla = pipeServPhantomFromMilla.WaitForConnectionAsync();
                }
                if (!pipeServPhantomFromMilla.IsConnected)
                {
                    Thread.Sleep(250);
                    continue;
                }
                if (reader == null)
                {
                    reader = new StreamReader(pipeServPhantomFromMilla);
                }

                if (!reader.EndOfStream)
                {
                    messagesReceived.Add(reader.ReadLine());
                    //AddDebugLine("Received: " + text);
                }
                else
                {
                    AddDebugLine("End of stream...");
                }
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSpawnVelocity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCharacterSelect_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendTextThroughPipe("character_swap," + cmbCharacterSelect.SelectedIndex.ToString());
        }

        private void btnShowAdvancedWarp_Click(object sender, EventArgs e)
        {
            if (frmWarpAdvanced == null || frmWarpAdvanced.IsDisposed)
            {
                frmWarpAdvanced = new FormWarpAdvanced();
            }

            frmWarpAdvanced.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtSendDebugCommand.Text.EndsWith("\n"))
            {
                var sendText = txtSendDebugCommand.Text.Trim();
                SendTextThroughPipe(sendText);
                txtSendDebugCommand.Text = "";
            }
        }

        public void ParseCommand(string txt)
        {
            if (String.IsNullOrEmpty(txt))
            {
                return;
            }

            var parts = txt.Replace(" ", "").Split(',');
            var cmd = parts[0].ToLower();
            if (cmd.Equals("set_character_ids"))
            {
                SetCharacterIDs(parts);
            }
            else if (cmd.Equals("set_scene_list"))
            {
                SetSceneList(parts);
            }
            else if (cmd.Equals("set_shield_ids"))
            {
                SetShieldIDs(parts);
            }
        }

        public void SetCharacterIDs(string[] ids)
        {
            cmbCharacterSelect.Items.Clear();
            for (int i = 1; i < ids.Length; i++)
            {
                cmbCharacterSelect.Items.Add(ids[i]);
            }
        }

        public void SetSceneList(string[] sceneNames)
        {
            cmbScenes.Items.Clear();
            for (int i = 1; i < sceneNames.Length; i++)
            {
                cmbScenes.Items.Add(sceneNames[i]);
            }
        }

        public void SetShieldIDs(string[] shieldNames)
        {
            cmbShieldType.Items.Clear();
            for (int i = 1; i < shieldNames.Length; i++)
            {
                cmbShieldType.Items.Add(shieldNames[i]);
            }
        }

        private void tmrFetchValues_Tick(object sender, EventArgs e)
        {
            if (!requestedInitValues)
            {
                //tmrFetchValues.Enabled = false;
                if (SendTextThroughPipe("get_character_ids") == false)
                {
                    AddDebugLine("Cannot request Character IDs as connection has not been established.");
                    return;
                }

                
                SendTextThroughPipe("get_scene_list");
                SendTextThroughPipe("get_shield_ids");
                requestedInitValues = true;
            }
            else
            {
                if (messagesReceived.Count > 0)
                {
                    AddDebugLine(messagesReceived[0]);

                    ParseCommand(messagesReceived[0]);
                    
                    messagesReceived.RemoveAt(0);
                }
                else
                {
                    AddDebugLine("No messages to read...");
                }
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (reader != null) { reader.Close(); }
            if (writer != null) { writer.Close(); }

            if (pipeServPhantomFromMilla != null)
            {
                if (asyncResultFromMilla != null)
                {
                    //pipeServPhantomFromMilla.EndWaitForConnection(asyncResultFromMilla);
                }
                pipeServPhantomFromMilla.Close();
            }
            if (pipeServPhantomToMilla != null)
            {
                if (asyncResultToMilla != null)
                {
                    //pipeServPhantomToMilla.EndWaitForConnection(asyncResultToMilla);
                }
                pipeServPhantomToMilla.Close();
            }
            if (pipeServPhantomToMilla != null) { pipeServPhantomToMilla.Close(); }
            if (pipeServPhantomFromMilla != null) { pipeServPhantomFromMilla.Close(); }
            Application.Exit();
        }

        public void UpdateTextLog()
        {
            txtSendLog.Text = "";
            foreach (var line in DebugLines)
            {
                txtSendLog.Text += line + "\r\n";
            }
        }

        public void AddDebugLine(string line)
        {
            if (DebugLines.Count > MaxDebugLines)
            {
                DebugLines.RemoveAt(DebugLines.Count - 1);
            }

            DebugLines.Insert(0, line);
            UpdateTextLog();
        }
    }
}