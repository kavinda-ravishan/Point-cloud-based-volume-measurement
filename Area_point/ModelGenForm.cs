using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Area_point
{
    public partial class ModelGenForm : Form
    {
        public ModelGenForm()
        {
            InitializeComponent();
            for (int i = 0; i <= 100; i++)
            {
                comboBoxPercentage.Items.Add(i);
            }
            comboBoxPercentage.SelectedIndex = 1;
        }

        public Form RefToMainForm { get; set; }

        private float RandGen(Random random, int value = 100, int percentage = 1)
        {
            value = (int)(value * (percentage / 100f) * 100);
            return random.Next(-value, value) / 100f; ;
        }

        private void ModelGenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToMainForm.Show();
        }

        private void GtnGen_Click(object sender, EventArgs e)
        {
            #region Generate points
            List<PointEx> pointsEx = new List<PointEx>();
            Random random = new Random();

            float theta_steps = (float)(System.Convert.ToDouble(textBoxThetaStepSize.Text));
            float lambda_steps = (float)(System.Convert.ToDouble(textBoxLambdaStepSizeS.Text));
            float z_steps_c = (float)(System.Convert.ToDouble(textBoxZStepSizeC.Text));
            float z_from_c = (float)System.Convert.ToDouble(textBoxZfromC.Text);
            float z_to_c = (float)System.Convert.ToDouble(textBoxZToC.Text);
            float radius = (float)System.Convert.ToDouble(textBoxRadius.Text);

            ModelVolume.updated = true;
            ModelVolume.volumeS = (2 * Math.PI * radius * radius * radius) / 3;
            ModelVolume.volumeC = Math.PI * radius * radius * (z_to_c - z_from_c);

            if (checkBoxNoise.Checked)//generate points with noise
            {
                int percentage = comboBoxPercentage.SelectedIndex;

                for (float z = z_from_c; z <= z_to_c; z = z + z_steps_c)
                {
                    for (float t = 0; t < 360; t = t + theta_steps)
                    {
                        pointsEx.Add(ConvertCoordinate.CylindricalToCartesianEx(t, radius + RandGen(random,(int)radius,percentage), z, 0));
                    }
                }

                for (float l = lambda_steps; l < 90; l = l + lambda_steps)
                {
                    for (float t = 0; t < 360; t = t + theta_steps)
                    {
                        pointsEx.Add(ConvertCoordinate.SphericalToCartesianEx(radius + RandGen(random, (int)radius, percentage), l, t, z_to_c));
                    }
                }
                pointsEx.Add(ConvertCoordinate.SphericalToCartesianEx(radius + RandGen(random, (int)radius, percentage), 90, 0, z_to_c)); // Bottom point
            }
            else//whiout noise
            {
                for (float z = z_from_c; z <= z_to_c; z = z + z_steps_c)
                {
                    for (float t = 0; t < 360; t = t + theta_steps)
                    {
                        pointsEx.Add(ConvertCoordinate.CylindricalToCartesianEx(t, radius, z, 0));
                    }
                }

                for (float l = lambda_steps; l < 90; l = l + lambda_steps)
                {
                    for (float t = 0; t < 360; t = t + theta_steps)
                    {
                        pointsEx.Add(ConvertCoordinate.SphericalToCartesianEx(radius, l, t, z_to_c));
                    }
                }
                pointsEx.Add(ConvertCoordinate.SphericalToCartesianEx(radius, 90, 0, z_to_c)); // Bottom point
            }
            #endregion

            #region Generate faces for points
            List<Fase> faces = new List<Fase>();
            int N = (int)(360 / theta_steps);
            int pointCount = pointsEx.Count;

            Calculate.GetFaces(ref faces,ref pointsEx, N, Model.Complete_Model);
            #endregion

            Write.PCDFileEx(ref pointsEx);
            Write.OBJFileEx(ref pointsEx,ref faces, "Points");
            Write.ModelFileEx(ref pointsEx, "PointsEx");

            pointsEx.Clear();
            faces.Clear();
        }

        private void LinklblOpenModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("GeneratedFiles\\Points.obj");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBoxNoise_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoise.Checked)
            {
                comboBoxPercentage.Enabled = true;
            }
            else
            {
                comboBoxPercentage.Enabled = false;
            }
        }
    }
}
