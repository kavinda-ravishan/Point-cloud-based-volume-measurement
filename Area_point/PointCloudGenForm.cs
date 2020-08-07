using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Area_point
{
    public partial class PointCloudGenForm : Form
    {
        public PointCloudGenForm()
        {
            InitializeComponent();
        }
        
        public Form RefToMainForm { get; set; }

        private void PointCloudGenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToMainForm.Show();
        }

        private void GtnGen_Click(object sender, EventArgs e)
        {
            List<Point> points = new List<Point>();

            float RadiusC = (float)(System.Convert.ToDouble(textBoxRadiusC.Text));
            float ZFromC = (float)(System.Convert.ToDouble(textBoxZFromC.Text));
            float ZToC = (float)(System.Convert.ToDouble(textBoxZToC.Text));
            float ThetaFromC = (float)(System.Convert.ToDouble(textBoxThetaFromC.Text));
            float ThetaToC = (float)(System.Convert.ToDouble(textBoxThetaToC.Text));

            float RadiusS = (float)(System.Convert.ToDouble(textBoxRadiusS.Text));
            float ZStartS = (float)(System.Convert.ToDouble(textBoxZStartS.Text));
            float ThetaFromS = (float)(System.Convert.ToDouble(textBoxThetaFromS.Text));
            float ThetaToS = (float)(System.Convert.ToDouble(textBoxThetaToS.Text));
            float LambsaFromS = (float)(System.Convert.ToDouble(textBoxLambdaFromS.Text));
            float LambdaToS = (float)(System.Convert.ToDouble(textBoxLambdaToS.Text));


            for (float z = ZFromC; z < ZToC; z++)
            {
                for (float t = ThetaFromC; t < ThetaToC; t++)
                {
                    points.Add(ConvertCoordinate.CylindricalToCartesian(t, RadiusC, z, 0));
                }
            }

            for (float l = LambsaFromS; l < LambdaToS; l++)
            {
                for (float t = ThetaFromS; t < ThetaToS; t = t + 1)
                {
                    points.Add(ConvertCoordinate.SphericalToCartesian(RadiusS, l, t, ZStartS));
                }
            }
            Write.PCDFile(ref points);
            points.Clear();
        }
    }
}
