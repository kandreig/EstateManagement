namespace EstateMangenement.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.f1_dgvOwners = new System.Windows.Forms.DataGridView();
            this.f1_bAdd = new System.Windows.Forms.Button();
            this.f1_bDelete = new System.Windows.Forms.Button();
            this.f1_bModify = new System.Windows.Forms.Button();
            this.f1_lInfo = new System.Windows.Forms.Label();
            this.f1_bShowAllEstates = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.f1_dgvOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // f1_dgvOwners
            // 
            this.f1_dgvOwners.AllowUserToAddRows = false;
            this.f1_dgvOwners.AllowUserToDeleteRows = false;
            this.f1_dgvOwners.AllowUserToResizeColumns = false;
            this.f1_dgvOwners.AllowUserToResizeRows = false;
            this.f1_dgvOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.f1_dgvOwners.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.f1_dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f1_dgvOwners.GridColor = System.Drawing.Color.Black;
            this.f1_dgvOwners.Location = new System.Drawing.Point(148, 40);
            this.f1_dgvOwners.MultiSelect = false;
            this.f1_dgvOwners.Name = "f1_dgvOwners";
            this.f1_dgvOwners.ReadOnly = true;
            this.f1_dgvOwners.RowHeadersVisible = false;
            this.f1_dgvOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.f1_dgvOwners.Size = new System.Drawing.Size(544, 231);
            this.f1_dgvOwners.TabIndex = 0;
            this.f1_dgvOwners.DoubleClick += new System.EventHandler(this.f1_dgvOwners_DoubleClick);
            // 
            // f1_bAdd
            // 
            this.f1_bAdd.Location = new System.Drawing.Point(14, 40);
            this.f1_bAdd.Name = "f1_bAdd";
            this.f1_bAdd.Size = new System.Drawing.Size(128, 23);
            this.f1_bAdd.TabIndex = 1;
            this.f1_bAdd.Text = "add";
            this.f1_bAdd.UseVisualStyleBackColor = true;
            this.f1_bAdd.Click += new System.EventHandler(this.f1_bAdd_Click);
            // 
            // f1_bDelete
            // 
            this.f1_bDelete.Location = new System.Drawing.Point(14, 90);
            this.f1_bDelete.Name = "f1_bDelete";
            this.f1_bDelete.Size = new System.Drawing.Size(128, 23);
            this.f1_bDelete.TabIndex = 2;
            this.f1_bDelete.Text = "delete";
            this.f1_bDelete.UseVisualStyleBackColor = true;
            this.f1_bDelete.Click += new System.EventHandler(this.f1_bDelete_Click);
            // 
            // f1_bModify
            // 
            this.f1_bModify.Location = new System.Drawing.Point(14, 140);
            this.f1_bModify.Name = "f1_bModify";
            this.f1_bModify.Size = new System.Drawing.Size(128, 23);
            this.f1_bModify.TabIndex = 3;
            this.f1_bModify.Text = "modify";
            this.f1_bModify.UseVisualStyleBackColor = true;
            this.f1_bModify.Click += new System.EventHandler(this.f1_bModify_Click);
            // 
            // f1_lInfo
            // 
            this.f1_lInfo.AutoSize = true;
            this.f1_lInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1_lInfo.Location = new System.Drawing.Point(148, 9);
            this.f1_lInfo.Name = "f1_lInfo";
            this.f1_lInfo.Size = new System.Drawing.Size(288, 30);
            this.f1_lInfo.TabIndex = 4;
            this.f1_lInfo.Text = "                 Single Click to select owner\r\n                 Double click to s" +
    "how profile page of owner";
            // 
            // f1_bShowAllEstates
            // 
            this.f1_bShowAllEstates.Location = new System.Drawing.Point(584, 277);
            this.f1_bShowAllEstates.Name = "f1_bShowAllEstates";
            this.f1_bShowAllEstates.Size = new System.Drawing.Size(108, 23);
            this.f1_bShowAllEstates.TabIndex = 5;
            this.f1_bShowAllEstates.Text = "Show ALL estates";
            this.f1_bShowAllEstates.UseVisualStyleBackColor = true;
            this.f1_bShowAllEstates.Click += new System.EventHandler(this.f1_bShowAllEstates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 309);
            this.Controls.Add(this.f1_bShowAllEstates);
            this.Controls.Add(this.f1_lInfo);
            this.Controls.Add(this.f1_bModify);
            this.Controls.Add(this.f1_bDelete);
            this.Controls.Add(this.f1_bAdd);
            this.Controls.Add(this.f1_dgvOwners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Estate Mngr";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.f1_dgvOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView f1_dgvOwners;
        private System.Windows.Forms.Button f1_bAdd;
        private System.Windows.Forms.Button f1_bDelete;
        private System.Windows.Forms.Button f1_bModify;
        private System.Windows.Forms.Label f1_lInfo;
        private System.Windows.Forms.Button f1_bShowAllEstates;
    }
}

