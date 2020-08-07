using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_point
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExe_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("PointCloudViewer\\PointCloudViewer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPtnGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointCloudGenForm pointCloudGenForm = new PointCloudGenForm();
            pointCloudGenForm.RefToMainForm = this;
            pointCloudGenForm.Show();
        }

        private void BtnModGen_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelGenForm modelGenForm = new ModelGenForm();
            modelGenForm.RefToMainForm = this;
            modelGenForm.Show();
        }

        private void BtnVolumeCal_Click(object sender, EventArgs e)
        {
            this.Hide();
            VolumeCalForm volumeCalForm = new VolumeCalForm();
            volumeCalForm.RefToMainForm = this;
            volumeCalForm.Show();
        }
    }
}
