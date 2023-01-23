namespace PhantomCube
{
    partial class FormWarpAdvanced
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkStartWithSpeed = new System.Windows.Forms.CheckBox();
            this.chkRNGSeed = new System.Windows.Forms.CheckBox();
            this.chkMeter = new System.Windows.Forms.CheckBox();
            this.chkSpecialItem = new System.Windows.Forms.CheckBox();
            this.btnRequestCurrentState = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadSettingsWarp = new System.Windows.Forms.Button();
            this.btnSaveSettingsWarp = new System.Windows.Forms.Button();
            this.txtStartWithSpeed = new System.Windows.Forms.TextBox();
            this.txtRNGSeed = new System.Windows.Forms.TextBox();
            this.txtStartMeter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkStartWithSpeed
            // 
            this.chkStartWithSpeed.AutoSize = true;
            this.chkStartWithSpeed.Location = new System.Drawing.Point(6, 22);
            this.chkStartWithSpeed.Name = "chkStartWithSpeed";
            this.chkStartWithSpeed.Size = new System.Drawing.Size(110, 19);
            this.chkStartWithSpeed.TabIndex = 0;
            this.chkStartWithSpeed.Text = "Start with speed";
            this.chkStartWithSpeed.UseVisualStyleBackColor = true;
            // 
            // chkRNGSeed
            // 
            this.chkRNGSeed.AutoSize = true;
            this.chkRNGSeed.Location = new System.Drawing.Point(6, 47);
            this.chkRNGSeed.Name = "chkRNGSeed";
            this.chkRNGSeed.Size = new System.Drawing.Size(78, 19);
            this.chkRNGSeed.TabIndex = 1;
            this.chkRNGSeed.Text = "RNG Seed";
            this.chkRNGSeed.UseVisualStyleBackColor = true;
            // 
            // chkMeter
            // 
            this.chkMeter.AutoSize = true;
            this.chkMeter.Location = new System.Drawing.Point(6, 72);
            this.chkMeter.Name = "chkMeter";
            this.chkMeter.Size = new System.Drawing.Size(57, 19);
            this.chkMeter.TabIndex = 2;
            this.chkMeter.Text = "Meter";
            this.chkMeter.UseVisualStyleBackColor = true;
            // 
            // chkSpecialItem
            // 
            this.chkSpecialItem.AutoSize = true;
            this.chkSpecialItem.Location = new System.Drawing.Point(6, 97);
            this.chkSpecialItem.Name = "chkSpecialItem";
            this.chkSpecialItem.Size = new System.Drawing.Size(143, 19);
            this.chkSpecialItem.TabIndex = 3;
            this.chkSpecialItem.Text = "Start with Special Item";
            this.chkSpecialItem.UseVisualStyleBackColor = true;
            // 
            // btnRequestCurrentState
            // 
            this.btnRequestCurrentState.Location = new System.Drawing.Point(0, 22);
            this.btnRequestCurrentState.Name = "btnRequestCurrentState";
            this.btnRequestCurrentState.Size = new System.Drawing.Size(256, 34);
            this.btnRequestCurrentState.TabIndex = 4;
            this.btnRequestCurrentState.Text = "Get Current State";
            this.btnRequestCurrentState.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStartMeter);
            this.groupBox1.Controls.Add(this.txtRNGSeed);
            this.groupBox1.Controls.Add(this.txtStartWithSpeed);
            this.groupBox1.Controls.Add(this.chkStartWithSpeed);
            this.groupBox1.Controls.Add(this.chkRNGSeed);
            this.groupBox1.Controls.Add(this.chkSpecialItem);
            this.groupBox1.Controls.Add(this.chkMeter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 138);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadSettingsWarp);
            this.groupBox2.Controls.Add(this.btnSaveSettingsWarp);
            this.groupBox2.Controls.Add(this.btnRequestCurrentState);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnLoadSettingsWarp
            // 
            this.btnLoadSettingsWarp.Location = new System.Drawing.Point(122, 61);
            this.btnLoadSettingsWarp.Name = "btnLoadSettingsWarp";
            this.btnLoadSettingsWarp.Size = new System.Drawing.Size(134, 34);
            this.btnLoadSettingsWarp.TabIndex = 6;
            this.btnLoadSettingsWarp.Text = "Load Settings";
            this.btnLoadSettingsWarp.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettingsWarp
            // 
            this.btnSaveSettingsWarp.Location = new System.Drawing.Point(0, 61);
            this.btnSaveSettingsWarp.Name = "btnSaveSettingsWarp";
            this.btnSaveSettingsWarp.Size = new System.Drawing.Size(116, 34);
            this.btnSaveSettingsWarp.TabIndex = 5;
            this.btnSaveSettingsWarp.Text = "Save Settings";
            this.btnSaveSettingsWarp.UseVisualStyleBackColor = true;
            // 
            // txtStartWithSpeed
            // 
            this.txtStartWithSpeed.Location = new System.Drawing.Point(156, 20);
            this.txtStartWithSpeed.Name = "txtStartWithSpeed";
            this.txtStartWithSpeed.Size = new System.Drawing.Size(100, 23);
            this.txtStartWithSpeed.TabIndex = 4;
            this.txtStartWithSpeed.Text = "0";
            // 
            // txtRNGSeed
            // 
            this.txtRNGSeed.Location = new System.Drawing.Point(156, 45);
            this.txtRNGSeed.Name = "txtRNGSeed";
            this.txtRNGSeed.Size = new System.Drawing.Size(100, 23);
            this.txtRNGSeed.TabIndex = 5;
            this.txtRNGSeed.Text = "0";
            // 
            // txtStartMeter
            // 
            this.txtStartMeter.Location = new System.Drawing.Point(156, 70);
            this.txtStartMeter.Name = "txtStartMeter";
            this.txtStartMeter.Size = new System.Drawing.Size(100, 23);
            this.txtStartMeter.TabIndex = 6;
            this.txtStartMeter.Text = "0";
            // 
            // FormWarpAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 269);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormWarpAdvanced";
            this.Text = "FormWarpAdvanced";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox chkStartWithSpeed;
        private CheckBox chkRNGSeed;
        private CheckBox chkMeter;
        private CheckBox chkSpecialItem;
        private Button btnRequestCurrentState;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnLoadSettingsWarp;
        private Button btnSaveSettingsWarp;
        private TextBox txtStartMeter;
        private TextBox txtRNGSeed;
        private TextBox txtStartWithSpeed;
    }
}