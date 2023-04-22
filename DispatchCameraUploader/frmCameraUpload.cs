using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DispatchCameraUploader
{
    public partial class frmCameraUpload : Form
    {
        public string destination { get; set; }
        public frmCameraUpload()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar2.Minimum = 0;
                progressBar2.Maximum = 100;

                progressBar2.Value = 0;

                float totalFileCount;
                float newFileCount;
                float progressValue;
                int progressValueInt;



                string path = txtSource.Text;
                var files = Directory.EnumerateFiles(path, "*.jpg", SearchOption.AllDirectories).Select(fn => new FileInfo(fn));
                var fileDateGroups = files.GroupBy(fi => fi.LastWriteTime.Date);
                totalFileCount = files.Count();




                foreach (var dateGroup in fileDateGroups)
                {
                    string dir = Path.Combine(destination, dateGroup.Key.ToString("yyyy-MM-dd"));
                    //string dir = Path.Combine(@"C:\Users\Aled\Desktop\2", dateGroup.Key.ToString("yyyy-MM-dd"));

                    Directory.CreateDirectory(dir);
                    foreach (var file in dateGroup)
                    {
                        string newPath = Path.Combine(dir, file.Name);
                        File.Copy(file.FullName, newPath, true);
                        File.Delete(file.FullName);

                        newFileCount = files.Count();

                        progressValue = (1 - (newFileCount / totalFileCount)) * 100;
                        progressValueInt = (int)Math.Round(progressValue);

                        progressBar2.Value = progressValueInt;
                        progressBar2.Update();


                    }
                }

                //^^^^ jpgs



                //same again but for movies
                path = txtSource.Text;
                files = Directory.EnumerateFiles(path, "*.avi", SearchOption.AllDirectories).Select(fn => new FileInfo(fn));
                fileDateGroups = files.GroupBy(fi => fi.LastWriteTime.Date);
                totalFileCount = files.Count();

                progressBar2.Minimum = 0;
                progressBar2.Maximum = 100;

                progressBar2.Value = 0;


                foreach (var dateGroup in fileDateGroups)
                {
                    string dir = Path.Combine(destination, dateGroup.Key.ToString("yyyy-MM-dd"));
                    //string dir = Path.Combine(@"C:\Users\Aled\Desktop\2", dateGroup.Key.ToString("yyyy-MM-dd"));

                    Directory.CreateDirectory(dir);
                    foreach (var file in dateGroup)
                    {
                        string newPath = Path.Combine(dir, file.Name);
                        File.Copy(file.FullName, newPath, true);
                        File.Delete(file.FullName);

                        newFileCount = files.Count();

                        progressValue = (1 - (newFileCount / totalFileCount)) * 100;
                        progressValueInt = (int)Math.Round(progressValue);

                        progressBar2.Value = progressValueInt;
                        progressBar2.Update();


                    }
                }

                MessageBox.Show("File Upload Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rd_packing_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"G:\";
            destination = @"\\designsvr1\Public\Slimline Photos and Videos\Slimline Packing";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"E:\";
            destination = @"\\designsvr1\public\Shop Pictures";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"G:\";
            destination = @"\\DESIGNSVR1\public\Slimline Photos and Videos\Shop floor  operation video`s";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"F:\";
            destination = @"\\designsvr1\Public\Dispatch pictures";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"E:\";
            destination = @"\\designsvr1\Public\Welding pictures";
        }

        private void rdo_slimline_dispatch_CheckedChanged(object sender, EventArgs e)
        {
            txtSource.Text = @"G:\";
            destination = @"\\designsvr1\Public\Slimline Photos and Videos\Slimline Dispatch";
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            Process.Start(@"\\DESIGNSVR1\public\Slimline Photos and Videos\Shop floor  operation video`s");
        }

        private void btnPacking_Click(object sender, EventArgs e)
        {
            Process.Start(@"\\designsvr1\Public\Slimline Photos and Videos\Slimline Packing");
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            Process.Start(@"\\designsvr1\Public\Slimline Photos and Videos\Slimline Dispatch");
        }
    }
}

