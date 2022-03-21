using EstateManagement.Models;
using EstateManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateMangenement.UI
{
    public partial class Form5 : Form
    {
        internal Estate  selectedEstate = new Estate();
        List<Picture> pictures = new List<Picture>();
        IRepository<Picture> pictureR = RepositoryFactory.CreatePictureRepository();
        IRepository<Estate> estateR = RepositoryFactory.CreateEstateRepository();
        string pictureSavePath = ConfigurationManager.AppSettings["picturePath"];
        int picIndex = 0;


        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            f5_lPicturePath.MaximumSize = new Size(300, 0);
            f5_lPicturePath.AutoSize = true;

            f5_lEstateInfo.MaximumSize = new Size(400, 0);
            f5_lEstateInfo.AutoSize = true;
            f5_lEstateInfo.Text = selectedEstate.ToString();


            UpdateEstateInfo();
            UpdatePictureTracker();
            DisplayLoadImage();

        }

       
        private void UpdatePictureTracker()
        {
            if (pictures.Count > 0)
            {
                string format = picIndex + 1 + "/" + pictures.Count;
                f5_lPictureTracker.Text = format;
            }
            else
            {

                f5_lPictureTracker.Text = "0/0";
            }
                
        }

        private void UpdateEstateInfo()
        {
            UpdateEstate();

            f5_lEstateInfo.Text = selectedEstate.ToString();
        }

        private void UpdateEstate()
        {
            selectedEstate = estateR.GetById(selectedEstate.Id);
            pictures = selectedEstate.Pictures;
        }

        private void DisplayLoadImage()
        {
            UpdateEstate();
            try
            {
                if (pictures.Count > 0)
                {
                    f5_pb.ImageLocation = Path.Combine(pictureSavePath, pictures[0].Id.ToString() + ".jpg");

                } else if (pictures.Count == 0)
                {
                    f5_pb.BackColor = Color.Black;
                    f5_pb.ImageLocation = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void f5_bSearchPicture_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
            ofd.ShowDialog();

            f5_lPicturePath.Text = ofd.FileName;

        }

        private void SaveOnDisk( string finalPicturePath)
        {

                if (!Directory.Exists(pictureSavePath))
                {
                    Directory.CreateDirectory(pictureSavePath);
                    MessageBox.Show("Directory missing\nCreated Directory at " + pictureSavePath);
                }

                if (string.IsNullOrEmpty(f5_lPicturePath.Text))
                {
                    throw new Exception("No picture selected to add");
                }

                File.Copy(f5_lPicturePath.Text, finalPicturePath);

                MessageBox.Show("Picture successfully saved!");
            

        }
        private void SaveOnCloud(Guid guid)
        {

                Picture pic = new Picture()
                {
                    Name = guid + ".jpg",
                    CreateDate = DateTime.Now,
                    EstateId = selectedEstate.Id
                };


                pictureR.Create(pic);

                UpdateEstateInfo();

        }
        private void f5_bAddPicture_Click(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid();
            
            try
            {
                SaveOnCloud(guid);
                UpdateEstateInfo();


                int lastPicture = pictures.Count - 1;
                int idLastPicture = pictures[lastPicture].Id;
                string picture = idLastPicture.ToString();

                var finalPicturePath = Path.Combine(pictureSavePath, picture + ".jpg");

                SaveOnDisk( finalPicturePath);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            picIndex = 0;

            UpdatePictureTracker();
            UpdateEstateInfo();
            DisplayLoadImage();

            f5_lPicturePath.Text = "";


        }
        private void DeleteFromDisk(string picture)
        {
            File.Delete(picture);
        }
        private void f5_bDeletePicture_Click(object sender, EventArgs e)
        {
            var picture = Convert.ToInt32(Path.GetFileNameWithoutExtension(f5_pb.ImageLocation));

            string deleteMessage = "Deleting picture !!\nAre you sure?";
            string titleMessage = "Deleting picture..";

            try
            {
                if (MessageBox.Show(deleteMessage, titleMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pictureR.Delete(picture);
                    DeleteFromDisk(f5_pb.ImageLocation);

                    picIndex = 0;

                    UpdateEstateInfo();
                    UpdatePictureTracker();
                    DisplayLoadImage();
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void f5_bDeselectPicture_Click(object sender, EventArgs e)
        {
            f5_lPicturePath.Text = "";
        }
        private void f5_bNextPicture_Click(object sender, EventArgs e)
        {
            int picNrMax = pictures.Count;

            

            if (picIndex < picNrMax-1)
            {
                picIndex++;
                string picPath = Path.Combine(pictureSavePath, pictures[picIndex].Id.ToString() + ".jpg");
                f5_pb.ImageLocation = picPath;
            }


            UpdatePictureTracker();
        }
        private void f5_bPreviousPicture_Click(object sender, EventArgs e)
        {

            if (picIndex > 0) 
            {
                picIndex--;
                string picPath = Path.Combine(pictureSavePath, pictures[picIndex].Id.ToString() + ".jpg");
                f5_pb.ImageLocation = picPath;
            }


            UpdatePictureTracker();
        }



















        private void CheckIntegrity()
        {
            UpdateEstateInfo();



            var pictureOnDiskFullPath = Directory.GetFiles(pictureSavePath);
            var pictureOnDisk = new List<string>();
            var pictureOnCloud = new List<string>();

            foreach (string file in pictureOnDiskFullPath)
            {
                pictureOnDisk.Add(Path.GetFileName(file));
            }

            foreach (Picture picture in pictures)
            {
                pictureOnCloud.Add(picture.Name);
            }

            var pictureOnDiskToDelete = new List<string>();
            var pictureOnCloudToDelete = new List<string>();

            foreach (string picture in pictureOnDisk)
            {
                if (!pictureOnCloud.Contains(picture)) { pictureOnDiskToDelete.Add(picture); }
            }

            foreach (string picture in pictureOnCloud)
            {
                if (!pictureOnDisk.Contains(picture)) { pictureOnCloudToDelete.Add(picture); }
            }



            int nPictureOnDiskToDelete = pictureOnDiskToDelete.Count;
            int nPictureOnCloudToDelete = pictureOnCloudToDelete.Count;

            string deleteMessage = "We found " + (nPictureOnCloudToDelete + nPictureOnDiskToDelete) + " pictures that does not correspond, do you want to continue to DELETE?";
            string titleMessage = "INTEGRITY VIOLATED";
            try
            {
                if (MessageBox.Show(deleteMessage, titleMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (string picture in pictureOnDiskToDelete)
                    {
                        File.Delete(Path.GetFullPath(picture)); //not working path.getfullpath
                    }
                    foreach (string picture in pictureOnCloudToDelete)
                    {
                        var pic = pictures.Where(x => x.Name == picture).First();
                        pictureR.Delete(pic.Id);
                    }

                    MessageBox.Show("Operation Succed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }
}
