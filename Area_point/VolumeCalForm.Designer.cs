namespace Area_point
{
    partial class VolumeCalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VolumeCalForm));
            this.btnReadModel = new System.Windows.Forms.Button();
            this.lblVolumeS = new System.Windows.Forms.Label();
            this.lblVolumeC = new System.Windows.Forms.Label();
            this.progressBarS = new System.Windows.Forms.ProgressBar();
            this.lblPrograssS = new System.Windows.Forms.Label();
            this.lblPrograssC = new System.Windows.Forms.Label();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.lblVolC = new System.Windows.Forms.Label();
            this.lblVolS = new System.Windows.Forms.Label();
            this.lblErrorS = new System.Windows.Forms.Label();
            this.lblErrorC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReadModel
            // 
            this.btnReadModel.Location = new System.Drawing.Point(150, 173);
            this.btnReadModel.Name = "btnReadModel";
            this.btnReadModel.Size = new System.Drawing.Size(100, 30);
            this.btnReadModel.TabIndex = 0;
            this.btnReadModel.Text = "Read Model";
            this.btnReadModel.UseVisualStyleBackColor = true;
            this.btnReadModel.Click += new System.EventHandler(this.BtnReadModel_Click);
            // 
            // lblVolumeS
            // 
            this.lblVolumeS.AutoSize = true;
            this.lblVolumeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeS.Location = new System.Drawing.Point(115, 7);
            this.lblVolumeS.Name = "lblVolumeS";
            this.lblVolumeS.Size = new System.Drawing.Size(43, 13);
            this.lblVolumeS.TabIndex = 2;
            this.lblVolumeS.Text = "---------";
            this.lblVolumeS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVolumeC
            // 
            this.lblVolumeC.AutoSize = true;
            this.lblVolumeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeC.Location = new System.Drawing.Point(115, 53);
            this.lblVolumeC.Name = "lblVolumeC";
            this.lblVolumeC.Size = new System.Drawing.Size(43, 13);
            this.lblVolumeC.TabIndex = 5;
            this.lblVolumeC.Text = "---------";
            this.lblVolumeC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarS
            // 
            this.progressBarS.Location = new System.Drawing.Point(12, 98);
            this.progressBarS.Name = "progressBarS";
            this.progressBarS.Size = new System.Drawing.Size(360, 14);
            this.progressBarS.TabIndex = 6;
            // 
            // lblPrograssS
            // 
            this.lblPrograssS.AutoSize = true;
            this.lblPrograssS.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograssS.Location = new System.Drawing.Point(170, 115);
            this.lblPrograssS.Name = "lblPrograssS";
            this.lblPrograssS.Size = new System.Drawing.Size(23, 14);
            this.lblPrograssS.TabIndex = 7;
            this.lblPrograssS.Text = "----";
            // 
            // lblPrograssC
            // 
            this.lblPrograssC.AutoSize = true;
            this.lblPrograssC.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrograssC.Location = new System.Drawing.Point(170, 148);
            this.lblPrograssC.Name = "lblPrograssC";
            this.lblPrograssC.Size = new System.Drawing.Size(23, 14);
            this.lblPrograssC.TabIndex = 9;
            this.lblPrograssC.Text = "----";
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(12, 131);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(360, 14);
            this.progressBarC.TabIndex = 8;
            // 
            // lblVolC
            // 
            this.lblVolC.AutoSize = true;
            this.lblVolC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolC.Location = new System.Drawing.Point(30, 55);
            this.lblVolC.Name = "lblVolC";
            this.lblVolC.Size = new System.Drawing.Size(56, 13);
            this.lblVolC.TabIndex = 11;
            this.lblVolC.Text = "Volume :";
            this.lblVolC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVolS
            // 
            this.lblVolS.AutoSize = true;
            this.lblVolS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolS.Location = new System.Drawing.Point(30, 9);
            this.lblVolS.Name = "lblVolS";
            this.lblVolS.Size = new System.Drawing.Size(56, 13);
            this.lblVolS.TabIndex = 10;
            this.lblVolS.Text = "Volume :";
            this.lblVolS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorS
            // 
            this.lblErrorS.AutoSize = true;
            this.lblErrorS.ForeColor = System.Drawing.Color.Red;
            this.lblErrorS.Location = new System.Drawing.Point(127, 29);
            this.lblErrorS.Name = "lblErrorS";
            this.lblErrorS.Size = new System.Drawing.Size(13, 13);
            this.lblErrorS.TabIndex = 12;
            this.lblErrorS.Text = "--";
            // 
            // lblErrorC
            // 
            this.lblErrorC.AutoSize = true;
            this.lblErrorC.ForeColor = System.Drawing.Color.Red;
            this.lblErrorC.Location = new System.Drawing.Point(127, 75);
            this.lblErrorC.Name = "lblErrorC";
            this.lblErrorC.Size = new System.Drawing.Size(13, 13);
            this.lblErrorC.TabIndex = 13;
            this.lblErrorC.Text = "--";
            // 
            // VolumeCalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lblErrorC);
            this.Controls.Add(this.lblErrorS);
            this.Controls.Add(this.lblVolC);
            this.Controls.Add(this.lblVolS);
            this.Controls.Add(this.lblPrograssC);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.lblPrograssS);
            this.Controls.Add(this.progressBarS);
            this.Controls.Add(this.lblVolumeC);
            this.Controls.Add(this.lblVolumeS);
            this.Controls.Add(this.btnReadModel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VolumeCalForm";
            this.Text = "Volume Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VolumeCalForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadModel;
        private System.Windows.Forms.Label lblVolumeS;
        private System.Windows.Forms.Label lblVolumeC;
        private System.Windows.Forms.ProgressBar progressBarS;
        private System.Windows.Forms.Label lblPrograssS;
        private System.Windows.Forms.Label lblPrograssC;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.Label lblVolC;
        private System.Windows.Forms.Label lblVolS;
        private System.Windows.Forms.Label lblErrorS;
        private System.Windows.Forms.Label lblErrorC;
    }
}