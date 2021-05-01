namespace PasswordGenerator
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelAbout = new System.Windows.Forms.Label();
            this.MyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelAbout.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout.ForeColor = System.Drawing.Color.White;
            this.labelAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAbout.Location = new System.Drawing.Point(44, 3);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(432, 97);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "Password Generator v2.0 (22032021)";
            this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAbout.Click += new System.EventHandler(this.labelAbout_Click);
            // 
            // MyLinkLabel
            // 
            this.MyLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MyLinkLabel.AutoSize = true;
            this.MyLinkLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyLinkLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MyLinkLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.MyLinkLabel.Location = new System.Drawing.Point(203, 77);
            this.MyLinkLabel.Name = "MyLinkLabel";
            this.MyLinkLabel.Size = new System.Drawing.Size(77, 23);
            this.MyLinkLabel.TabIndex = 2;
            this.MyLinkLabel.TabStop = true;
            this.MyLinkLabel.Text = "GitHub";
            this.MyLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGit_LinkClicked);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PasswordGenerator.Properties.Resources.password;
            this.pictureBox.Location = new System.Drawing.Point(8, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(71, 37);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(460, 120);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.MyLinkLabel);
            this.Controls.Add(this.labelAbout);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.LinkLabel MyLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}