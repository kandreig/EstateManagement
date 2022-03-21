namespace EstateMangenement.UI
{
    partial class Form5
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
            this.f5_pb = new System.Windows.Forms.PictureBox();
            this.f5_lEstateInfo = new System.Windows.Forms.Label();
            this.f5_bPreviousPicture = new System.Windows.Forms.Button();
            this.f5_bNextPicture = new System.Windows.Forms.Button();
            this.f5_bSearchPicture = new System.Windows.Forms.Button();
            this.f5_bAddPicture = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.f5_lPicturePath = new System.Windows.Forms.Label();
            this.f5_bDeletePicture = new System.Windows.Forms.Button();
            this.f5_bDeselectPicture = new System.Windows.Forms.Button();
            this.f5_lPictureTracker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f5_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // f5_pb
            // 
            this.f5_pb.Location = new System.Drawing.Point(82, 56);
            this.f5_pb.Name = "f5_pb";
            this.f5_pb.Size = new System.Drawing.Size(682, 488);
            this.f5_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f5_pb.TabIndex = 0;
            this.f5_pb.TabStop = false;
            // 
            // f5_lEstateInfo
            // 
            this.f5_lEstateInfo.AutoSize = true;
            this.f5_lEstateInfo.Location = new System.Drawing.Point(44, 18);
            this.f5_lEstateInfo.Name = "f5_lEstateInfo";
            this.f5_lEstateInfo.Size = new System.Drawing.Size(56, 13);
            this.f5_lEstateInfo.TabIndex = 1;
            this.f5_lEstateInfo.Text = "estate info";
            // 
            // f5_bPreviousPicture
            // 
            this.f5_bPreviousPicture.Location = new System.Drawing.Point(12, 194);
            this.f5_bPreviousPicture.Name = "f5_bPreviousPicture";
            this.f5_bPreviousPicture.Size = new System.Drawing.Size(33, 200);
            this.f5_bPreviousPicture.TabIndex = 2;
            this.f5_bPreviousPicture.Text = "P\r\nR\r\nE\r\nV";
            this.f5_bPreviousPicture.UseVisualStyleBackColor = true;
            this.f5_bPreviousPicture.Click += new System.EventHandler(this.f5_bPreviousPicture_Click);
            // 
            // f5_bNextPicture
            // 
            this.f5_bNextPicture.Location = new System.Drawing.Point(806, 194);
            this.f5_bNextPicture.Name = "f5_bNextPicture";
            this.f5_bNextPicture.Size = new System.Drawing.Size(33, 200);
            this.f5_bNextPicture.TabIndex = 3;
            this.f5_bNextPicture.Text = "N\r\nE\r\nX\r\nT\r\n";
            this.f5_bNextPicture.UseVisualStyleBackColor = true;
            this.f5_bNextPicture.Click += new System.EventHandler(this.f5_bNextPicture_Click);
            // 
            // f5_bSearchPicture
            // 
            this.f5_bSearchPicture.Location = new System.Drawing.Point(201, 580);
            this.f5_bSearchPicture.Name = "f5_bSearchPicture";
            this.f5_bSearchPicture.Size = new System.Drawing.Size(86, 42);
            this.f5_bSearchPicture.TabIndex = 4;
            this.f5_bSearchPicture.Text = "Search Picture\r\non disk";
            this.f5_bSearchPicture.UseVisualStyleBackColor = true;
            this.f5_bSearchPicture.Click += new System.EventHandler(this.f5_bSearchPicture_Click);
            // 
            // f5_bAddPicture
            // 
            this.f5_bAddPicture.Location = new System.Drawing.Point(331, 570);
            this.f5_bAddPicture.Name = "f5_bAddPicture";
            this.f5_bAddPicture.Size = new System.Drawing.Size(95, 23);
            this.f5_bAddPicture.TabIndex = 5;
            this.f5_bAddPicture.Text = "Add Picture";
            this.f5_bAddPicture.UseVisualStyleBackColor = true;
            this.f5_bAddPicture.Click += new System.EventHandler(this.f5_bAddPicture_Click);
            // 
            // f5_lPicturePath
            // 
            this.f5_lPicturePath.AutoSize = true;
            this.f5_lPicturePath.Location = new System.Drawing.Point(198, 657);
            this.f5_lPicturePath.Name = "f5_lPicturePath";
            this.f5_lPicturePath.Size = new System.Drawing.Size(0, 13);
            this.f5_lPicturePath.TabIndex = 6;
            // 
            // f5_bDeletePicture
            // 
            this.f5_bDeletePicture.Location = new System.Drawing.Point(516, 590);
            this.f5_bDeletePicture.Name = "f5_bDeletePicture";
            this.f5_bDeletePicture.Size = new System.Drawing.Size(85, 23);
            this.f5_bDeletePicture.TabIndex = 7;
            this.f5_bDeletePicture.Text = "Delete Picture";
            this.f5_bDeletePicture.UseVisualStyleBackColor = true;
            this.f5_bDeletePicture.Click += new System.EventHandler(this.f5_bDeletePicture_Click);
            // 
            // f5_bDeselectPicture
            // 
            this.f5_bDeselectPicture.Location = new System.Drawing.Point(331, 608);
            this.f5_bDeselectPicture.Name = "f5_bDeselectPicture";
            this.f5_bDeselectPicture.Size = new System.Drawing.Size(95, 23);
            this.f5_bDeselectPicture.TabIndex = 8;
            this.f5_bDeselectPicture.Text = "Deselect Picture";
            this.f5_bDeselectPicture.UseVisualStyleBackColor = true;
            this.f5_bDeselectPicture.Click += new System.EventHandler(this.f5_bDeselectPicture_Click);
            // 
            // f5_lPictureTracker
            // 
            this.f5_lPictureTracker.AutoSize = true;
            this.f5_lPictureTracker.Location = new System.Drawing.Point(426, 547);
            this.f5_lPictureTracker.Name = "f5_lPictureTracker";
            this.f5_lPictureTracker.Size = new System.Drawing.Size(0, 13);
            this.f5_lPictureTracker.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 740);
            this.Controls.Add(this.f5_lPictureTracker);
            this.Controls.Add(this.f5_bDeselectPicture);
            this.Controls.Add(this.f5_bDeletePicture);
            this.Controls.Add(this.f5_lPicturePath);
            this.Controls.Add(this.f5_bAddPicture);
            this.Controls.Add(this.f5_bSearchPicture);
            this.Controls.Add(this.f5_bNextPicture);
            this.Controls.Add(this.f5_bPreviousPicture);
            this.Controls.Add(this.f5_lEstateInfo);
            this.Controls.Add(this.f5_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estate Pictures";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f5_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox f5_pb;
        private System.Windows.Forms.Label f5_lEstateInfo;
        private System.Windows.Forms.Button f5_bPreviousPicture;
        private System.Windows.Forms.Button f5_bNextPicture;
        private System.Windows.Forms.Button f5_bSearchPicture;
        private System.Windows.Forms.Button f5_bAddPicture;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label f5_lPicturePath;
        private System.Windows.Forms.Button f5_bDeletePicture;
        private System.Windows.Forms.Button f5_bDeselectPicture;
        private System.Windows.Forms.Label f5_lPictureTracker;
    }
}