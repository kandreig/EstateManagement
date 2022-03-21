namespace EstateMangenement.UI
{
    partial class Form3
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
            this.f3_lInfo = new System.Windows.Forms.Label();
            this.f3_bModify = new System.Windows.Forms.Button();
            this.f3_bDelete = new System.Windows.Forms.Button();
            this.f3_bAdd = new System.Windows.Forms.Button();
            this.f3_lOwnerInfo = new System.Windows.Forms.Label();
            this.f3_dgvEstates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.f3_dgvEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // f3_lInfo
            // 
            this.f3_lInfo.AutoSize = true;
            this.f3_lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3_lInfo.Location = new System.Drawing.Point(409, 11);
            this.f3_lInfo.Name = "f3_lInfo";
            this.f3_lInfo.Size = new System.Drawing.Size(287, 30);
            this.f3_lInfo.TabIndex = 9;
            this.f3_lInfo.Text = "                 Single Click to select estate\r\n                 Double click to " +
    "show profile page of estate\r\n";
            // 
            // f3_bModify
            // 
            this.f3_bModify.Location = new System.Drawing.Point(12, 194);
            this.f3_bModify.Name = "f3_bModify";
            this.f3_bModify.Size = new System.Drawing.Size(128, 23);
            this.f3_bModify.TabIndex = 8;
            this.f3_bModify.Text = "modify";
            this.f3_bModify.UseVisualStyleBackColor = true;
            this.f3_bModify.Click += new System.EventHandler(this.f3_bModify_Click);
            // 
            // f3_bDelete
            // 
            this.f3_bDelete.Location = new System.Drawing.Point(12, 144);
            this.f3_bDelete.Name = "f3_bDelete";
            this.f3_bDelete.Size = new System.Drawing.Size(128, 23);
            this.f3_bDelete.TabIndex = 7;
            this.f3_bDelete.Text = "delete";
            this.f3_bDelete.UseVisualStyleBackColor = true;
            this.f3_bDelete.Click += new System.EventHandler(this.f3_bDelete_Click);
            // 
            // f3_bAdd
            // 
            this.f3_bAdd.Location = new System.Drawing.Point(12, 94);
            this.f3_bAdd.Name = "f3_bAdd";
            this.f3_bAdd.Size = new System.Drawing.Size(128, 23);
            this.f3_bAdd.TabIndex = 6;
            this.f3_bAdd.Text = "add";
            this.f3_bAdd.UseVisualStyleBackColor = true;
            this.f3_bAdd.Click += new System.EventHandler(this.f3_bAdd_Click);
            // 
            // f3_lOwnerInfo
            // 
            this.f3_lOwnerInfo.AutoSize = true;
            this.f3_lOwnerInfo.Location = new System.Drawing.Point(149, 9);
            this.f3_lOwnerInfo.Name = "f3_lOwnerInfo";
            this.f3_lOwnerInfo.Size = new System.Drawing.Size(65, 13);
            this.f3_lOwnerInfo.TabIndex = 10;
            this.f3_lOwnerInfo.Text = "Owner Info -";
            // 
            // f3_dgvEstates
            // 
            this.f3_dgvEstates.AllowUserToAddRows = false;
            this.f3_dgvEstates.AllowUserToDeleteRows = false;
            this.f3_dgvEstates.AllowUserToResizeColumns = false;
            this.f3_dgvEstates.AllowUserToResizeRows = false;
            this.f3_dgvEstates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.f3_dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f3_dgvEstates.Location = new System.Drawing.Point(152, 44);
            this.f3_dgvEstates.MultiSelect = false;
            this.f3_dgvEstates.Name = "f3_dgvEstates";
            this.f3_dgvEstates.ReadOnly = true;
            this.f3_dgvEstates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f3_dgvEstates.Size = new System.Drawing.Size(744, 231);
            this.f3_dgvEstates.TabIndex = 11;
            this.f3_dgvEstates.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.f3_dgvEstates_CellFormatting);
            this.f3_dgvEstates.DoubleClick += new System.EventHandler(this.f3_dgvEstates_DoubleClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 297);
            this.Controls.Add(this.f3_dgvEstates);
            this.Controls.Add(this.f3_lOwnerInfo);
            this.Controls.Add(this.f3_lInfo);
            this.Controls.Add(this.f3_bModify);
            this.Controls.Add(this.f3_bDelete);
            this.Controls.Add(this.f3_bAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Estate Mngr - estates";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f3_dgvEstates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f3_lInfo;
        private System.Windows.Forms.Button f3_bModify;
        private System.Windows.Forms.Button f3_bDelete;
        private System.Windows.Forms.Button f3_bAdd;
        private System.Windows.Forms.Label f3_lOwnerInfo;
        private System.Windows.Forms.DataGridView f3_dgvEstates;
    }
}