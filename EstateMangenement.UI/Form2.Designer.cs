namespace EstateMangenement.UI
{
    partial class Form2
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
            this.f2_lName = new System.Windows.Forms.Label();
            this.f2_tbName = new System.Windows.Forms.TextBox();
            this.f2_tbEmail = new System.Windows.Forms.TextBox();
            this.f2_lEmail = new System.Windows.Forms.Label();
            this.f2_tbPhone = new System.Windows.Forms.TextBox();
            this.f2_lPhone = new System.Windows.Forms.Label();
            this.f2_tbCnp = new System.Windows.Forms.TextBox();
            this.f2_lCnp = new System.Windows.Forms.Label();
            this.f2_bAdd = new System.Windows.Forms.Button();
            this.f2_bModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f2_lName
            // 
            this.f2_lName.AutoSize = true;
            this.f2_lName.Location = new System.Drawing.Point(41, 48);
            this.f2_lName.Name = "f2_lName";
            this.f2_lName.Size = new System.Drawing.Size(33, 13);
            this.f2_lName.TabIndex = 0;
            this.f2_lName.Text = "name";
            // 
            // f2_tbName
            // 
            this.f2_tbName.Location = new System.Drawing.Point(82, 45);
            this.f2_tbName.Name = "f2_tbName";
            this.f2_tbName.Size = new System.Drawing.Size(100, 20);
            this.f2_tbName.TabIndex = 1;
            // 
            // f2_tbEmail
            // 
            this.f2_tbEmail.Location = new System.Drawing.Point(82, 71);
            this.f2_tbEmail.Name = "f2_tbEmail";
            this.f2_tbEmail.Size = new System.Drawing.Size(166, 20);
            this.f2_tbEmail.TabIndex = 3;
            // 
            // f2_lEmail
            // 
            this.f2_lEmail.AutoSize = true;
            this.f2_lEmail.Location = new System.Drawing.Point(41, 74);
            this.f2_lEmail.Name = "f2_lEmail";
            this.f2_lEmail.Size = new System.Drawing.Size(31, 13);
            this.f2_lEmail.TabIndex = 2;
            this.f2_lEmail.Text = "email";
            // 
            // f2_tbPhone
            // 
            this.f2_tbPhone.Location = new System.Drawing.Point(82, 97);
            this.f2_tbPhone.Name = "f2_tbPhone";
            this.f2_tbPhone.Size = new System.Drawing.Size(100, 20);
            this.f2_tbPhone.TabIndex = 5;
            // 
            // f2_lPhone
            // 
            this.f2_lPhone.AutoSize = true;
            this.f2_lPhone.Location = new System.Drawing.Point(41, 100);
            this.f2_lPhone.Name = "f2_lPhone";
            this.f2_lPhone.Size = new System.Drawing.Size(37, 13);
            this.f2_lPhone.TabIndex = 4;
            this.f2_lPhone.Text = "phone";
            // 
            // f2_tbCnp
            // 
            this.f2_tbCnp.Location = new System.Drawing.Point(82, 123);
            this.f2_tbCnp.Name = "f2_tbCnp";
            this.f2_tbCnp.Size = new System.Drawing.Size(100, 20);
            this.f2_tbCnp.TabIndex = 7;
            // 
            // f2_lCnp
            // 
            this.f2_lCnp.AutoSize = true;
            this.f2_lCnp.Location = new System.Drawing.Point(41, 126);
            this.f2_lCnp.Name = "f2_lCnp";
            this.f2_lCnp.Size = new System.Drawing.Size(25, 13);
            this.f2_lCnp.TabIndex = 6;
            this.f2_lCnp.Text = "cnp";
            // 
            // f2_bAdd
            // 
            this.f2_bAdd.Location = new System.Drawing.Point(60, 161);
            this.f2_bAdd.Name = "f2_bAdd";
            this.f2_bAdd.Size = new System.Drawing.Size(138, 31);
            this.f2_bAdd.TabIndex = 8;
            this.f2_bAdd.Text = "SUBMIT";
            this.f2_bAdd.UseVisualStyleBackColor = true;
            this.f2_bAdd.Click += new System.EventHandler(this.f2_bRegister_Click);
            // 
            // f2_bModify
            // 
            this.f2_bModify.Location = new System.Drawing.Point(60, 161);
            this.f2_bModify.Name = "f2_bModify";
            this.f2_bModify.Size = new System.Drawing.Size(138, 31);
            this.f2_bModify.TabIndex = 9;
            this.f2_bModify.Text = "SUBMIT";
            this.f2_bModify.UseVisualStyleBackColor = true;
            this.f2_bModify.Click += new System.EventHandler(this.f2_bModify_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 264);
            this.Controls.Add(this.f2_bModify);
            this.Controls.Add(this.f2_bAdd);
            this.Controls.Add(this.f2_tbCnp);
            this.Controls.Add(this.f2_lCnp);
            this.Controls.Add(this.f2_tbPhone);
            this.Controls.Add(this.f2_lPhone);
            this.Controls.Add(this.f2_tbEmail);
            this.Controls.Add(this.f2_lEmail);
            this.Controls.Add(this.f2_tbName);
            this.Controls.Add(this.f2_lName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Estate Mngr - REG";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f2_lName;
        private System.Windows.Forms.TextBox f2_tbName;
        private System.Windows.Forms.TextBox f2_tbEmail;
        private System.Windows.Forms.Label f2_lEmail;
        private System.Windows.Forms.TextBox f2_tbPhone;
        private System.Windows.Forms.Label f2_lPhone;
        private System.Windows.Forms.TextBox f2_tbCnp;
        private System.Windows.Forms.Label f2_lCnp;
        private System.Windows.Forms.Button f2_bAdd;
        private System.Windows.Forms.Button f2_bModify;
    }
}