using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateMangenement.UI
{
    public partial class Form2 : Form
    {

        IRepository<Owner> ownerR = RepositoryFactory.CreateOwnerRepository();
        internal Owner selectedOwner = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void f2_bRegister_Click(object sender, EventArgs e)
        {
            bool tbEmpty = false;
            foreach(TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tbEmpty = true;
                    break;
                }
            }

            try
            {
                var OwnerToAdd = new Owner
                {
                    Name = f2_tbName.Text,
                    Email = f2_tbEmail.Text,
                    Phone = f2_tbPhone.Text,
                    CNP = f2_tbCnp.Text
                };

                if (tbEmpty) throw new Exception("All fields must be filled");

                ownerR.Create(OwnerToAdd);
                

                MessageBox.Show("Owner added successfully");

                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("CNP must be 13 chars");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        internal void HideFieldsForModify()
        {

            f2_tbCnp.Enabled = false;

            f2_bAdd.Hide();
        }
        internal void HideFieldsForAdd()
        {

            f2_bModify.Hide();
        }



        private void f2_bModify_Click(object sender, EventArgs e)
        {
            try
            {
                var OwnerToModify = selectedOwner;

                bool Changed = f2_tbEmail.Text == selectedOwner.Email &&
                                f2_tbPhone.Text == selectedOwner.Phone &&
                                f2_tbName.Text == selectedOwner.Name;

                if (Changed) throw new Exception("You didn't modify anything!");

                OwnerToModify.Name = f2_tbName.Text;
                OwnerToModify.Email = f2_tbEmail.Text;
                OwnerToModify.Phone = f2_tbPhone.Text;

                ownerR.Update(OwnerToModify);

                MessageBox.Show("Owner successfully updated");

                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        internal void LoadFildesForModify(Owner selectedOwner)
        {
            this.selectedOwner = selectedOwner;
            f2_tbName.Text = selectedOwner.Name;
            f2_tbEmail.Text = selectedOwner.Email;
            f2_tbPhone.Text = selectedOwner.Phone;
            f2_tbCnp.Text = selectedOwner.CNP;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
