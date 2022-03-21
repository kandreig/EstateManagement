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
    public partial class Form4 : Form
    {

        private IRepository<Estate> estateR = RepositoryFactory.CreateEstateRepository();
        internal Estate selectedEstate = null;
        internal Owner selectedOwner = null;

        public Form4()
        {
            InitializeComponent();

            f4_cbType.Items.AddRange(new object[]
            {
                EstateTypeEnum.App,
                EstateTypeEnum.House,
                EstateTypeEnum.Ground,
                EstateTypeEnum.Office
            });

            Form1 form1 = new Form1();
            f4_cbOwnerId.DataSource = form1.GetOwnersIds();
        }


        private void f4_bAdd_Click(object sender, EventArgs e)
        {
            bool tbEmpty = false;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    tbEmpty = true;
                    break;
                }
            }

            if (string.IsNullOrEmpty(f4_cbType.Text))
            {
                tbEmpty = true;
            }

            try
            {
                if (tbEmpty) throw new Exception("All fields must be filled");

                string s = f4_cbType.SelectedItem.ToString();
                EstateTypeEnum f4_cbSelect = (EstateTypeEnum)Enum.Parse(typeof(EstateTypeEnum), s);

                var EstateToAdd = new Estate
                {
                    Name = f4_tbName.Text,
                    Address = f4_tbAddress.Text,
                    OwnerId = Convert.ToInt32(f4_cbOwnerId.Text),
                    Price = Convert.ToDouble(f4_tbPrice.Text),
                    Type = (int)f4_cbSelect,
                    CreateDate = DateTime.Now
                };

                estateR.Create(EstateToAdd);
                MessageBox.Show("Estate added successfully");

                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        internal void HideFieldsForAdd()
        {
            f4_bModify.Hide();
        }
        internal void LockOwnerId()
        {
            f4_cbOwnerId.Text = selectedOwner.Id.ToString();
            f4_cbOwnerId.Enabled = false;
        }

   

        private void f4_bModify_Click(object sender, EventArgs e)
        {
            try
            {
                var EstateToModify = selectedEstate;

                string s = f4_cbType.SelectedItem.ToString();
                EstateTypeEnum f4_cbSelect = (EstateTypeEnum)Enum.Parse(typeof(EstateTypeEnum), s);

                bool Changed = f4_tbName.Text == selectedEstate.Name &&
                                f4_tbAddress.Text == selectedEstate.Address &&
                                f4_cbOwnerId.Text == selectedEstate.OwnerId.ToString() &&
                                f4_tbPrice.Text == selectedEstate.Price.ToString() &&
                                (int)f4_cbSelect == selectedEstate.Type;

                if (Changed) throw new Exception("You didn't modify anything!");

                EstateToModify.Name = f4_tbName.Text;
                EstateToModify.Address = f4_tbAddress.Text;
                EstateToModify.OwnerId = Convert.ToInt32(f4_cbOwnerId.Text);
                EstateToModify.Price = Convert.ToDouble(f4_tbPrice.Text);
                EstateToModify.Type = (int)f4_cbSelect;

                estateR.Update(EstateToModify);

                MessageBox.Show("Owner successfully updated");
                this.Hide();
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Must assign an existing owner");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        internal void HideFieldForModify()
        {
            f4_bAdd.Hide();
        }
        internal void LoadFildesForModify(Estate selectedEstate)
        {
            f4_tbName.Text = selectedEstate.Name;
            f4_tbAddress.Text = selectedEstate.Address;
            f4_cbOwnerId.Text = selectedEstate.OwnerId.ToString();
            f4_tbPrice.Text = selectedEstate.Price.ToString();
            f4_cbType.SelectedIndex = selectedEstate.Type-1;
        }
    }
}
