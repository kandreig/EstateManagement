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
    public partial class Form3 : Form
    {
        IRepository<Estate> estateR = RepositoryFactory.CreateEstateRepository();
        IRepository<Owner> ownerR = RepositoryFactory.CreateOwnerRepository();
        internal Owner selectedOwner = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {



            if (!(selectedOwner is null))
            {
                selectedOwner = ownerR.GetById(selectedOwner.Id);
                f3_lOwnerInfo.Text = selectedOwner.ToString();
                f3_dgvEstates.DataSource = selectedOwner.Estates;
            }
            else
            {
                f3_dgvEstates.DataSource = estateR.GetAll();
            }

        }

        private void f3_bAdd_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.selectedOwner = selectedOwner;

            if (selectedOwner != null)
            {
                
                form4.LockOwnerId();
            }

            
            form4.HideFieldsForAdd();
            form4.ShowDialog();

            UpdateGrid();
        }
        private void UpdateGrid()
        {
            if (!(selectedOwner is null))
            {
                selectedOwner = ownerR.GetById(selectedOwner.Id);
                f3_dgvEstates.DataSource = selectedOwner.Estates;
            }
            else
            {
                f3_dgvEstates.DataSource = estateR.GetAll();
            }
        }

        private void f3_bDelete_Click(object sender, EventArgs e)
        {
            var selectedEstate = f3_dgvEstates.SelectedRows[0].DataBoundItem as Estate;

            string deleteMessage = "Deleting Estate with !!  ID " + selectedEstate.Id + "  !!\nAre you sure?";
            string titleMessage = "Deleting Estate..";

            try
            {
                if (MessageBox.Show(deleteMessage, titleMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    estateR.Delete(selectedEstate.Id);
                    UpdateGrid();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: Must delete all pictures before deleting estate");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

            

        }

        private void f3_bModify_Click(object sender, EventArgs e)
        {
            var selectedEstate = f3_dgvEstates.SelectedRows[0].DataBoundItem as Estate;
            Form4 form4 = new Form4();
            form4.HideFieldForModify();
            form4.LoadFildesForModify(selectedEstate);
            form4.ShowDialog();

            UpdateGrid();
        }

        private void f3_dgvEstates_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                try
                {

                    e.Value = (EstateTypeEnum)Enum.Parse(typeof(EstateTypeEnum), e.Value.ToString());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void f3_dgvEstates_DoubleClick(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.selectedEstate = f3_dgvEstates.SelectedRows[0].DataBoundItem as Estate;
            this.Hide();
            form5.ShowDialog();
            this.Show();
        }
    }
}
