namespace Img2Wav
{
    partial class frmMain
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
            this.ofdInputImage = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbxInputImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sfdOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.cldColor = new System.Windows.Forms.ColorDialog();
            this.panColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInputImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(386, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 21);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbxInputImage
            // 
            this.pbxInputImage.BackColor = System.Drawing.Color.Black;
            this.pbxInputImage.InitialImage = null;
            this.pbxInputImage.Location = new System.Drawing.Point(3, 3);
            this.pbxInputImage.Name = "pbxInputImage";
            this.pbxInputImage.Size = new System.Drawing.Size(821, 512);
            this.pbxInputImage.TabIndex = 3;
            this.pbxInputImage.TabStop = false;
            this.pbxInputImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxInputImage_MouseDown);
            this.pbxInputImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxInputImage_MouseMove);
            this.pbxInputImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxInputImage_MouseUp);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxInputImage);
            this.panel1.Location = new System.Drawing.Point(16, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 499);
            this.panel1.TabIndex = 5;
            // 
            // panColor
            // 
            this.panColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panColor.Location = new System.Drawing.Point(20, 11);
            this.panColor.Name = "panColor";
            this.panColor.Size = new System.Drawing.Size(346, 21);
            this.panColor.TabIndex = 6;
            this.panColor.Click += new System.EventHandler(this.panColor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 555);
            this.Controls.Add(this.panColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Img2Wav";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxInputImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdInputImage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbxInputImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog sfdOutputFile;
        private System.Windows.Forms.ColorDialog cldColor;
        private System.Windows.Forms.Panel panColor;
    }
}

