namespace EstateMangenement.UI
{
    partial class Form4
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
            this.f4_bModify = new System.Windows.Forms.Button();
            this.f4_bAdd = new System.Windows.Forms.Button();
            this.f4_tbPrice = new System.Windows.Forms.TextBox();
            this.f4_lPrice = new System.Windows.Forms.Label();
            this.f4_lOwnerId = new System.Windows.Forms.Label();
            this.f4_tbAddress = new System.Windows.Forms.TextBox();
            this.f4_lAddress = new System.Windows.Forms.Label();
            this.f4_tbName = new System.Windows.Forms.TextBox();
            this.f4_lName = new System.Windows.Forms.Label();
            this.f4_lType = new System.Windows.Forms.Label();
            this.f4_cbType = new System.Windows.Forms.ComboBox();
            this.f4_cbOwnerId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // f4_bModify
            // 
            this.f4_bModify.Location = new System.Drawing.Point(56, 190);
            this.f4_bModify.Name = "f4_bModify";
            this.f4_bModify.Size = new System.Drawing.Size(138, 31);
            this.f4_bModify.TabIndex = 19;
            this.f4_bModify.Text = "SUBMIT";
            this.f4_bModify.UseVisualStyleBackColor = true;
            this.f4_bModify.Click += new System.EventHandler(this.f4_bModify_Click);
            // 
            // f4_bAdd
            // 
            this.f4_bAdd.Location = new System.Drawing.Point(56, 190);
            this.f4_bAdd.Name = "f4_bAdd";
            this.f4_bAdd.Size = new System.Drawing.Size(138, 31);
            this.f4_bAdd.TabIndex = 18;
            this.f4_bAdd.Text = "SUBMIT";
            this.f4_bAdd.UseVisualStyleBackColor = true;
            this.f4_bAdd.Click += new System.EventHandler(this.f4_bAdd_Click);
            // 
            // f4_tbPrice
            // 
            this.f4_tbPrice.Location = new System.Drawing.Point(74, 123);
            this.f4_tbPrice.Name = "f4_tbPrice";
            this.f4_tbPrice.Size = new System.Drawing.Size(100, 20);
            this.f4_tbPrice.TabIndex = 17;
            // 
            // f4_lPrice
            // 
            this.f4_lPrice.AutoSize = true;
            this.f4_lPrice.Location = new System.Drawing.Point(33, 126);
            this.f4_lPrice.Name = "f4_lPrice";
            this.f4_lPrice.Size = new System.Drawing.Size(30, 13);
            this.f4_lPrice.TabIndex = 16;
            this.f4_lPrice.Text = "price";
            // 
            // f4_lOwnerId
            // 
            this.f4_lOwnerId.AutoSize = true;
            this.f4_lOwnerId.Location = new System.Drawing.Point(18, 100);
            this.f4_lOwnerId.Name = "f4_lOwnerId";
            this.f4_lOwnerId.Size = new System.Drawing.Size(47, 13);
            this.f4_lOwnerId.TabIndex = 14;
            this.f4_lOwnerId.Text = "owner id";
            // 
            // f4_tbAddress
            // 
            this.f4_tbAddress.Location = new System.Drawing.Point(74, 71);
            this.f4_tbAddress.Name = "f4_tbAddress";
            this.f4_tbAddress.Size = new System.Drawing.Size(166, 20);
            this.f4_tbAddress.TabIndex = 13;
            // 
            // f4_lAddress
            // 
            this.f4_lAddress.AutoSize = true;
            this.f4_lAddress.Location = new System.Drawing.Point(24, 74);
            this.f4_lAddress.Name = "f4_lAddress";
            this.f4_lAddress.Size = new System.Drawing.Size(44, 13);
            this.f4_lAddress.TabIndex = 12;
            this.f4_lAddress.Text = "address";
            // 
            // f4_tbName
            // 
            this.f4_tbName.Location = new System.Drawing.Point(75, 45);
            this.f4_tbName.Name = "f4_tbName";
            this.f4_tbName.Size = new System.Drawing.Size(100, 20);
            this.f4_tbName.TabIndex = 11;
            // 
            // f4_lName
            // 
            this.f4_lName.AutoSize = true;
            this.f4_lName.Location = new System.Drawing.Point(33, 48);
            this.f4_lName.Name = "f4_lName";
            this.f4_lName.Size = new System.Drawing.Size(33, 13);
            this.f4_lName.TabIndex = 10;
            this.f4_lName.Text = "name";
            // 
            // f4_lType
            // 
            this.f4_lType.AutoSize = true;
            this.f4_lType.Location = new System.Drawing.Point(33, 152);
            this.f4_lType.Name = "f4_lType";
            this.f4_lType.Size = new System.Drawing.Size(27, 13);
            this.f4_lType.TabIndex = 20;
            this.f4_lType.Text = "type";
            // 
            // f4_cbType
            // 
            this.f4_cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f4_cbType.FormattingEnabled = true;
            this.f4_cbType.Location = new System.Drawing.Point(75, 152);
            this.f4_cbType.Name = "f4_cbType";
            this.f4_cbType.Size = new System.Drawing.Size(100, 21);
            this.f4_cbType.TabIndex = 21;
            // 
            // f4_cbOwnerId
            // 
            this.f4_cbOwnerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f4_cbOwnerId.FormattingEnabled = true;
            this.f4_cbOwnerId.Location = new System.Drawing.Point(75, 97);
            this.f4_cbOwnerId.Name = "f4_cbOwnerId";
            this.f4_cbOwnerId.Size = new System.Drawing.Size(66, 21);
            this.f4_cbOwnerId.TabIndex = 22;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 261);
            this.Controls.Add(this.f4_cbOwnerId);
            this.Controls.Add(this.f4_cbType);
            this.Controls.Add(this.f4_lType);
            this.Controls.Add(this.f4_bModify);
            this.Controls.Add(this.f4_bAdd);
            this.Controls.Add(this.f4_tbPrice);
            this.Controls.Add(this.f4_lPrice);
            this.Controls.Add(this.f4_lOwnerId);
            this.Controls.Add(this.f4_tbAddress);
            this.Controls.Add(this.f4_lAddress);
            this.Controls.Add(this.f4_tbName);
            this.Controls.Add(this.f4_lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f4_bModify;
        private System.Windows.Forms.Button f4_bAdd;
        private System.Windows.Forms.TextBox f4_tbPrice;
        private System.Windows.Forms.Label f4_lPrice;
        private System.Windows.Forms.Label f4_lOwnerId;
        private System.Windows.Forms.TextBox f4_tbAddress;
        private System.Windows.Forms.Label f4_lAddress;
        private System.Windows.Forms.TextBox f4_tbName;
        private System.Windows.Forms.Label f4_lName;
        private System.Windows.Forms.Label f4_lType;
        private System.Windows.Forms.ComboBox f4_cbType;
        private System.Windows.Forms.ComboBox f4_cbOwnerId;
    }
}