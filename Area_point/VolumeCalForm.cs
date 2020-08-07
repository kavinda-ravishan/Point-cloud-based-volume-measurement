using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Area_point
{
    public partial class VolumeCalForm : Form
    {
        public VolumeCalForm()
        {
            InitializeComponent();
            volumeS = new Volume();
            volumeC = new Volume();
            read = new ReadAsynchronous();

            volumeS.prograssChanged += VolumeS_prograssChanged;
            volumeS.volumeCalculated += VolumeS_volumeCalculated;

            volumeC.prograssChanged += VolumeC_prograssChanged;
            volumeC.volumeCalculated += VolumeC_volumeCalculated;

            read.prograssChanged += Read_prograssChanged;
            read.modelRead += Read_modelRead;
        }

        private void Read_modelRead(object sender, ModelReadEventArgs e)
        {
            pointsExC = new List<PointEx>();
            pointsExS = new List<PointEx>();

            facesC = new List<Fase>();
            facesS = new List<Fase>();

            #region Separate C and S and create obj files

            PointByTheta pointByTheta = new PointByTheta(ref read.points);

            for (int i = 0; i < read.points.Count; i++)
            {
                if (read.points[i].Lambda == 0) pointsExC.Add(read.points[i]);
                else pointsExS.Add(read.points[i]);
            }

            for (int i = pointsExC.Count - 1; i >= pointsExC.Count - pointByTheta.m_noOfThetaGroups; i--)
            {
                pointsExS.Insert(0, pointsExC[i]);
            }

            Calculate.GetFaces(ref facesC, ref pointsExC, pointByTheta.m_noOfThetaGroups, Model.cylinder);
            Calculate.GetFaces(ref facesS, ref pointsExS, pointByTheta.m_noOfThetaGroups, Model.sphere);

            Write.OBJFileEx(ref pointsExC, ref facesC, "C");
            Write.OBJFileEx(ref pointsExS, ref facesS, "S");

            #endregion

            #region Volume calculation

            threadS = new Thread(() => volumeS.TotalVolume(ref pointsExS, ref facesS, Model.sphere));
            threadC = new Thread(() => volumeC.TotalVolume(ref pointsExC, ref facesC, Model.cylinder));
            threadS.Start();
            threadC.Start();
            #endregion
        }

        private void Read_prograssChanged(object sender, ModelReadPrograssChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lblPrograssS.Text = e.prograss.ToString() + " / " + e.total.ToString();
                progressBarS.Value = (e.prograss * 100) / e.total;
            }));
        }

        private void VolumeC_volumeCalculated(object sender, VolumeCalculatedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (ModelVolume.updated)
                {
                    lblVolumeC.Text = e.volume.ToString() + " / " + ModelVolume.volumeC.ToString();
                    lblErrorC.Text = (100 - (float)(e.volume * 100 / ModelVolume.volumeC)).ToString() + " %";
                }
                else lblVolumeC.Text = e.volume.ToString();
            }));
        }

        private void VolumeC_prograssChanged(object sender, VolumePrograssChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lblPrograssC.Text = e.prograss.ToString() + " / " + e.total.ToString();
                progressBarC.Value = (e.prograss * 100) / e.total;
            }));
        }

        private void VolumeS_volumeCalculated(object sender, VolumeCalculatedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (ModelVolume.updated)
                {
                    lblVolumeS.Text = e.volume.ToString() + " / " + ModelVolume.volumeS.ToString();
                    lblErrorS.Text = (100 - (float)(e.volume * 100 / ModelVolume.volumeS)).ToString() + " %";
                }
                else lblVolumeS.Text = e.volume.ToString();
            }));
        }

        private void VolumeS_prograssChanged(object sender, VolumePrograssChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lblPrograssS.Text = e.prograss.ToString() + " / " + e.total.ToString();
                progressBarS.Value = (e.prograss * 100) / e.total;
            }));
        }

        public Form RefToMainForm { get; set; }

        private List<PointEx> pointsExC;
        private List<PointEx> pointsExS;

        private List<Fase> facesC; 
        private List<Fase> facesS;

        private Volume volumeS;
        private Volume volumeC;

        private ReadAsynchronous read;

        private Thread threadS;
        private Thread threadC;
        private Thread threadModelRead;

        private void VolumeCalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefToMainForm.Show();
        }

        private void BtnReadModel_Click(object sender, EventArgs e)
        {
            btnReadModel.Enabled = false;
            threadModelRead = new Thread(() => read.ModelFileEx());
            threadModelRead.Start();
        }
    }
}
