namespace AdapterObjectPool
{
    partial class TestForm
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
            this.pbNegative = new System.Windows.Forms.PictureBox();
            this.pb90cw = new System.Windows.Forms.PictureBox();
            this.pb90ccw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb90cw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb90ccw)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNegative
            // 
            this.pbNegative.Location = new System.Drawing.Point(13, 13);
            this.pbNegative.Name = "pbNegative";
            this.pbNegative.Size = new System.Drawing.Size(200, 200);
            this.pbNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNegative.TabIndex = 0;
            this.pbNegative.TabStop = false;
            // 
            // pb90cw
            // 
            this.pb90cw.Location = new System.Drawing.Point(263, 13);
            this.pb90cw.Name = "pb90cw";
            this.pb90cw.Size = new System.Drawing.Size(200, 200);
            this.pb90cw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb90cw.TabIndex = 1;
            this.pb90cw.TabStop = false;
            // 
            // pb90ccw
            // 
            this.pb90ccw.Location = new System.Drawing.Point(13, 271);
            this.pb90ccw.Name = "pb90ccw";
            this.pb90ccw.Size = new System.Drawing.Size(200, 200);
            this.pb90ccw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb90ccw.TabIndex = 2;
            this.pb90ccw.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 498);
            this.Controls.Add(this.pb90ccw);
            this.Controls.Add(this.pb90cw);
            this.Controls.Add(this.pbNegative);
            this.Name = "TestForm";
            this.Text = "Test form";
            ((System.ComponentModel.ISupportInitialize)(this.pbNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb90cw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb90ccw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNegative;
        private System.Windows.Forms.PictureBox pb90cw;
        private System.Windows.Forms.PictureBox pb90ccw;
    }
}

