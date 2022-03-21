using System;
using System.IO;
using System.Collections.Generic;

using System.Windows.Forms;
using EstateManagement.Repository;
using EstateManagement.Models;
using System.Data.SqlClient;

namespace EstateMangenement.UI
{
    public partial class Form1 : Form
    {
        IRepository<Owner> ownerR = RepositoryFactory.CreateOwnerRepository();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            f1_dgvOwners.DataSource = ownerR.GetAll();
        }

        private void f1_bDelete_Click(object sender, EventArgs e)
        {
            var selectedOwner = f1_dgvOwners.SelectedRows[0].DataBoundItem as Owner;

            string deleteMessage = "Deleting Owner with !!  ID "+ selectedOwner.Id + "  !!\nAre you sure?";
            string titleMessage = "Deleting owner..";
            
            try
            {
                if(MessageBox.Show(deleteMessage, titleMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ownerR.Delete(selectedOwner.Id);
                }
                
            }
            catch (SqlException exc)
            {

                MessageBox.Show("Can't delete owner that has ESTATES", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateGrid();
            
        }

        private void f1_bAdd_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.HideFieldsForAdd();
            form2.ShowDialog();

            UpdateGrid();
        }

        private void f1_bModify_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.HideFieldsForModify();
            var selectedOwner = f1_dgvOwners.SelectedRows[0].DataBoundItem as Owner;
            form2.LoadFildesForModify(selectedOwner);
            form2.ShowDialog();

            UpdateGrid();
        }

        private void f1_dgvOwners_DoubleClick(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            try
            {
                form3.selectedOwner = f1_dgvOwners.SelectedRows[0].DataBoundItem as Owner;
                this.Hide();
                form3.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no data");
            }
            
            
            
        }

       
        private void UpdateGrid()
        {

            f1_dgvOwners.DataSource = ownerR.GetAll();
        }


        private void f1_bShowAllEstates_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }
        internal List<int> GetOwnersIds()
        {
            List<int> ids = new List<int>();

            foreach (Owner owner in ownerR.GetAll())
            {
                ids.Add(owner.Id);
            }

            return ids;
        }
    }
}
