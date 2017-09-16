namespace Singleton
{
    partial class Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbFileNameInfo = new System.Windows.Forms.Label();
            this.btSaveAs = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbChannels = new System.Windows.Forms.Label();
            this.lbSampleRate = new System.Windows.Forms.Label();
            this.lbBPS = new System.Windows.Forms.Label();
            this.lbLengthInfo = new System.Windows.Forms.Label();
            this.lbChannelsInfo = new System.Windows.Forms.Label();
            this.lbSampleRateInfo = new System.Windows.Forms.Label();
            this.lbBPSInfo = new System.Windows.Forms.Label();
            this.lbDataLength = new System.Windows.Forms.Label();
            this.lbDataLengthInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Play_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StopPlay_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(12, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(12, 49);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(26, 13);
            this.lbFileName.TabIndex = 1;
            this.lbFileName.Text = "File:";
            // 
            // lbFileNameInfo
            // 
            this.lbFileNameInfo.AutoSize = true;
            this.lbFileNameInfo.Location = new System.Drawing.Point(74, 49);
            this.lbFileNameInfo.Name = "lbFileNameInfo";
            this.lbFileNameInfo.Size = new System.Drawing.Size(54, 13);
            this.lbFileNameInfo.TabIndex = 1;
            this.lbFileNameInfo.Text = "File Name";
            // 
            // btSaveAs
            // 
            this.btSaveAs.Location = new System.Drawing.Point(15, 24);
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btSaveAs.TabIndex = 0;
            this.btSaveAs.Text = "Save As";
            this.btSaveAs.UseVisualStyleBackColor = true;
            this.btSaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // btMove
            // 
            this.btMove.Location = new System.Drawing.Point(15, 53);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(75, 23);
            this.btMove.TabIndex = 2;
            this.btMove.Text = "Move File";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(15, 82);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete File";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(12, 85);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(43, 13);
            this.lbLength.TabIndex = 1;
            this.lbLength.Text = "Length:";
            // 
            // lbChannels
            // 
            this.lbChannels.AutoSize = true;
            this.lbChannels.Location = new System.Drawing.Point(12, 109);
            this.lbChannels.Name = "lbChannels";
            this.lbChannels.Size = new System.Drawing.Size(54, 13);
            this.lbChannels.TabIndex = 1;
            this.lbChannels.Text = "Channels:";
            // 
            // lbSampleRate
            // 
            this.lbSampleRate.AutoSize = true;
            this.lbSampleRate.Location = new System.Drawing.Point(12, 133);
            this.lbSampleRate.Name = "lbSampleRate";
            this.lbSampleRate.Size = new System.Drawing.Size(71, 13);
            this.lbSampleRate.TabIndex = 1;
            this.lbSampleRate.Text = "Sample Rate:";
            // 
            // lbBPS
            // 
            this.lbBPS.AutoSize = true;
            this.lbBPS.Location = new System.Drawing.Point(12, 157);
            this.lbBPS.Name = "lbBPS";
            this.lbBPS.Size = new System.Drawing.Size(84, 13);
            this.lbBPS.TabIndex = 1;
            this.lbBPS.Text = "Bits Per Sample:";
            // 
            // lbLengthInfo
            // 
            this.lbLengthInfo.AutoSize = true;
            this.lbLengthInfo.Location = new System.Drawing.Point(105, 85);
            this.lbLengthInfo.Name = "lbLengthInfo";
            this.lbLengthInfo.Size = new System.Drawing.Size(0, 13);
            this.lbLengthInfo.TabIndex = 1;
            // 
            // lbChannelsInfo
            // 
            this.lbChannelsInfo.AutoSize = true;
            this.lbChannelsInfo.Location = new System.Drawing.Point(105, 109);
            this.lbChannelsInfo.Name = "lbChannelsInfo";
            this.lbChannelsInfo.Size = new System.Drawing.Size(0, 13);
            this.lbChannelsInfo.TabIndex = 1;
            // 
            // lbSampleRateInfo
            // 
            this.lbSampleRateInfo.AutoSize = true;
            this.lbSampleRateInfo.Location = new System.Drawing.Point(105, 133);
            this.lbSampleRateInfo.Name = "lbSampleRateInfo";
            this.lbSampleRateInfo.Size = new System.Drawing.Size(0, 13);
            this.lbSampleRateInfo.TabIndex = 1;
            // 
            // lbBPSInfo
            // 
            this.lbBPSInfo.AutoSize = true;
            this.lbBPSInfo.Location = new System.Drawing.Point(105, 157);
            this.lbBPSInfo.Name = "lbBPSInfo";
            this.lbBPSInfo.Size = new System.Drawing.Size(0, 13);
            this.lbBPSInfo.TabIndex = 1;
            // 
            // lbDataLength
            // 
            this.lbDataLength.AutoSize = true;
            this.lbDataLength.Location = new System.Drawing.Point(12, 181);
            this.lbDataLength.Name = "lbDataLength";
            this.lbDataLength.Size = new System.Drawing.Size(69, 13);
            this.lbDataLength.TabIndex = 1;
            this.lbDataLength.Text = "Data Length:";
            // 
            // lbDataLengthInfo
            // 
            this.lbDataLengthInfo.AutoSize = true;
            this.lbDataLengthInfo.Location = new System.Drawing.Point(105, 181);
            this.lbDataLengthInfo.Name = "lbDataLengthInfo";
            this.lbDataLengthInfo.Size = new System.Drawing.Size(0, 13);
            this.lbDataLengthInfo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btMove);
            this.groupBox1.Controls.Add(this.btSaveAs);
            this.groupBox1.Location = new System.Drawing.Point(221, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files Work";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 213);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDataLengthInfo);
            this.Controls.Add(this.lbBPSInfo);
            this.Controls.Add(this.lbSampleRateInfo);
            this.Controls.Add(this.lbChannelsInfo);
            this.Controls.Add(this.lbLengthInfo);
            this.Controls.Add(this.lbFileNameInfo);
            this.Controls.Add(this.lbDataLength);
            this.Controls.Add(this.lbBPS);
            this.Controls.Add(this.lbSampleRate);
            this.Controls.Add(this.lbChannels);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Test";
            this.Text = "Singlton Test";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbFileNameInfo;
        private System.Windows.Forms.Button btSaveAs;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbChannels;
        private System.Windows.Forms.Label lbSampleRate;
        private System.Windows.Forms.Label lbBPS;
        private System.Windows.Forms.Label lbLengthInfo;
        private System.Windows.Forms.Label lbChannelsInfo;
        private System.Windows.Forms.Label lbSampleRateInfo;
        private System.Windows.Forms.Label lbBPSInfo;
        private System.Windows.Forms.Label lbDataLength;
        private System.Windows.Forms.Label lbDataLengthInfo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

