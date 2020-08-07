namespace Area_point
{
    partial class PointCloudGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointCloudGenForm));
            this.gtnGen = new System.Windows.Forms.Button();
            this.lblGenCylinder = new System.Windows.Forms.Label();
            this.lblGenSphere = new System.Windows.Forms.Label();
            this.lblZFromC = new System.Windows.Forms.Label();
            this.lblZToC = new System.Windows.Forms.Label();
            this.lblThetaToC = new System.Windows.Forms.Label();
            this.lblThetaFromC = new System.Windows.Forms.Label();
            this.lblThetaToS = new System.Windows.Forms.Label();
            this.lblThetaFromS = new System.Windows.Forms.Label();
            this.lblZStartS = new System.Windows.Forms.Label();
            this.lblLambdaToS = new System.Windows.Forms.Label();
            this.lblLambdaFromS = new System.Windows.Forms.Label();
            this.textBoxZFromC = new System.Windows.Forms.TextBox();
            this.textBoxZToC = new System.Windows.Forms.TextBox();
            this.textBoxThetaToC = new System.Windows.Forms.TextBox();
            this.textBoxThetaFromC = new System.Windows.Forms.TextBox();
            this.textBoxZStartS = new System.Windows.Forms.TextBox();
            this.textBoxThetaToS = new System.Windows.Forms.TextBox();
            this.textBoxThetaFromS = new System.Windows.Forms.TextBox();
            this.textBoxLambdaToS = new System.Windows.Forms.TextBox();
            this.textBoxLambdaFromS = new System.Windows.Forms.TextBox();
            this.textBoxRadiusC = new System.Windows.Forms.TextBox();
            this.lblRadiusC = new System.Windows.Forms.Label();
            this.textBoxRadiusS = new System.Windows.Forms.TextBox();
            this.lblRadiusS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gtnGen
            // 
            this.gtnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtnGen.Location = new System.Drawing.Point(14, 344);
            this.gtnGen.Name = "gtnGen";
            this.gtnGen.Size = new System.Drawing.Size(311, 34);
            this.gtnGen.TabIndex = 12;
            this.gtnGen.Text = "Generate";
            this.gtnGen.UseVisualStyleBackColor = true;
            this.gtnGen.Click += new System.EventHandler(this.GtnGen_Click);
            // 
            // lblGenCylinder
            // 
            this.lblGenCylinder.AutoSize = true;
            this.lblGenCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenCylinder.Location = new System.Drawing.Point(115, 9);
            this.lblGenCylinder.Name = "lblGenCylinder";
            this.lblGenCylinder.Size = new System.Drawing.Size(140, 17);
            this.lblGenCylinder.TabIndex = 13;
            this.lblGenCylinder.Text = "Generate Cylinder";
            // 
            // lblGenSphere
            // 
            this.lblGenSphere.AutoSize = true;
            this.lblGenSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenSphere.Location = new System.Drawing.Point(122, 149);
            this.lblGenSphere.Name = "lblGenSphere";
            this.lblGenSphere.Size = new System.Drawing.Size(133, 17);
            this.lblGenSphere.TabIndex = 2;
            this.lblGenSphere.Text = "Generate Sphere";
            // 
            // lblZFromC
            // 
            this.lblZFromC.AutoSize = true;
            this.lblZFromC.Location = new System.Drawing.Point(42, 79);
            this.lblZFromC.Name = "lblZFromC";
            this.lblZFromC.Size = new System.Drawing.Size(40, 13);
            this.lblZFromC.TabIndex = 15;
            this.lblZFromC.Text = "Z From";
            // 
            // lblZToC
            // 
            this.lblZToC.AutoSize = true;
            this.lblZToC.Location = new System.Drawing.Point(193, 79);
            this.lblZToC.Name = "lblZToC";
            this.lblZToC.Size = new System.Drawing.Size(20, 13);
            this.lblZToC.TabIndex = 16;
            this.lblZToC.Text = "To";
            // 
            // lblThetaToC
            // 
            this.lblThetaToC.AutoSize = true;
            this.lblThetaToC.Location = new System.Drawing.Point(192, 115);
            this.lblThetaToC.Name = "lblThetaToC";
            this.lblThetaToC.Size = new System.Drawing.Size(20, 13);
            this.lblThetaToC.TabIndex = 18;
            this.lblThetaToC.Text = "To";
            // 
            // lblThetaFromC
            // 
            this.lblThetaFromC.AutoSize = true;
            this.lblThetaFromC.Location = new System.Drawing.Point(20, 115);
            this.lblThetaFromC.Name = "lblThetaFromC";
            this.lblThetaFromC.Size = new System.Drawing.Size(61, 13);
            this.lblThetaFromC.TabIndex = 17;
            this.lblThetaFromC.Text = "Theta From";
            // 
            // lblThetaToS
            // 
            this.lblThetaToS.AutoSize = true;
            this.lblThetaToS.Location = new System.Drawing.Point(192, 266);
            this.lblThetaToS.Name = "lblThetaToS";
            this.lblThetaToS.Size = new System.Drawing.Size(20, 13);
            this.lblThetaToS.TabIndex = 22;
            this.lblThetaToS.Text = "To";
            // 
            // lblThetaFromS
            // 
            this.lblThetaFromS.AutoSize = true;
            this.lblThetaFromS.Location = new System.Drawing.Point(22, 266);
            this.lblThetaFromS.Name = "lblThetaFromS";
            this.lblThetaFromS.Size = new System.Drawing.Size(61, 13);
            this.lblThetaFromS.TabIndex = 21;
            this.lblThetaFromS.Text = "Theta From";
            // 
            // lblZStartS
            // 
            this.lblZStartS.AutoSize = true;
            this.lblZStartS.Location = new System.Drawing.Point(43, 226);
            this.lblZStartS.Name = "lblZStartS";
            this.lblZStartS.Size = new System.Drawing.Size(39, 13);
            this.lblZStartS.TabIndex = 20;
            this.lblZStartS.Text = "Z Start";
            // 
            // lblLambdaToS
            // 
            this.lblLambdaToS.AutoSize = true;
            this.lblLambdaToS.Location = new System.Drawing.Point(193, 305);
            this.lblLambdaToS.Name = "lblLambdaToS";
            this.lblLambdaToS.Size = new System.Drawing.Size(20, 13);
            this.lblLambdaToS.TabIndex = 24;
            this.lblLambdaToS.Text = "To";
            // 
            // lblLambdaFromS
            // 
            this.lblLambdaFromS.AutoSize = true;
            this.lblLambdaFromS.Location = new System.Drawing.Point(11, 305);
            this.lblLambdaFromS.Name = "lblLambdaFromS";
            this.lblLambdaFromS.Size = new System.Drawing.Size(71, 13);
            this.lblLambdaFromS.TabIndex = 23;
            this.lblLambdaFromS.Text = "Lambda From";
            // 
            // textBoxZFromC
            // 
            this.textBoxZFromC.Location = new System.Drawing.Point(88, 76);
            this.textBoxZFromC.Name = "textBoxZFromC";
            this.textBoxZFromC.Size = new System.Drawing.Size(100, 20);
            this.textBoxZFromC.TabIndex = 2;
            this.textBoxZFromC.Text = "0";
            // 
            // textBoxZToC
            // 
            this.textBoxZToC.Location = new System.Drawing.Point(219, 76);
            this.textBoxZToC.Name = "textBoxZToC";
            this.textBoxZToC.Size = new System.Drawing.Size(100, 20);
            this.textBoxZToC.TabIndex = 3;
            this.textBoxZToC.Text = "60";
            // 
            // textBoxThetaToC
            // 
            this.textBoxThetaToC.Location = new System.Drawing.Point(218, 112);
            this.textBoxThetaToC.Name = "textBoxThetaToC";
            this.textBoxThetaToC.Size = new System.Drawing.Size(100, 20);
            this.textBoxThetaToC.TabIndex = 5;
            this.textBoxThetaToC.Text = "360";
            // 
            // textBoxThetaFromC
            // 
            this.textBoxThetaFromC.Location = new System.Drawing.Point(87, 112);
            this.textBoxThetaFromC.Name = "textBoxThetaFromC";
            this.textBoxThetaFromC.Size = new System.Drawing.Size(100, 20);
            this.textBoxThetaFromC.TabIndex = 4;
            this.textBoxThetaFromC.Text = "0";
            // 
            // textBoxZStartS
            // 
            this.textBoxZStartS.Location = new System.Drawing.Point(88, 223);
            this.textBoxZStartS.Name = "textBoxZStartS";
            this.textBoxZStartS.Size = new System.Drawing.Size(100, 20);
            this.textBoxZStartS.TabIndex = 7;
            this.textBoxZStartS.Text = "60";
            // 
            // textBoxThetaToS
            // 
            this.textBoxThetaToS.Location = new System.Drawing.Point(218, 263);
            this.textBoxThetaToS.Name = "textBoxThetaToS";
            this.textBoxThetaToS.Size = new System.Drawing.Size(100, 20);
            this.textBoxThetaToS.TabIndex = 9;
            this.textBoxThetaToS.Text = "360";
            // 
            // textBoxThetaFromS
            // 
            this.textBoxThetaFromS.Location = new System.Drawing.Point(87, 263);
            this.textBoxThetaFromS.Name = "textBoxThetaFromS";
            this.textBoxThetaFromS.Size = new System.Drawing.Size(100, 20);
            this.textBoxThetaFromS.TabIndex = 8;
            this.textBoxThetaFromS.Text = "0";
            // 
            // textBoxLambdaToS
            // 
            this.textBoxLambdaToS.Location = new System.Drawing.Point(218, 302);
            this.textBoxLambdaToS.Name = "textBoxLambdaToS";
            this.textBoxLambdaToS.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambdaToS.TabIndex = 11;
            this.textBoxLambdaToS.Text = "90";
            // 
            // textBoxLambdaFromS
            // 
            this.textBoxLambdaFromS.Location = new System.Drawing.Point(87, 302);
            this.textBoxLambdaFromS.Name = "textBoxLambdaFromS";
            this.textBoxLambdaFromS.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambdaFromS.TabIndex = 10;
            this.textBoxLambdaFromS.Text = "0";
            // 
            // textBoxRadiusC
            // 
            this.textBoxRadiusC.Location = new System.Drawing.Point(88, 39);
            this.textBoxRadiusC.Name = "textBoxRadiusC";
            this.textBoxRadiusC.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusC.TabIndex = 1;
            this.textBoxRadiusC.Text = "50";
            // 
            // lblRadiusC
            // 
            this.lblRadiusC.AutoSize = true;
            this.lblRadiusC.Location = new System.Drawing.Point(41, 42);
            this.lblRadiusC.Name = "lblRadiusC";
            this.lblRadiusC.Size = new System.Drawing.Size(40, 13);
            this.lblRadiusC.TabIndex = 14;
            this.lblRadiusC.Text = "Radius";
            // 
            // textBoxRadiusS
            // 
            this.textBoxRadiusS.Location = new System.Drawing.Point(88, 185);
            this.textBoxRadiusS.Name = "textBoxRadiusS";
            this.textBoxRadiusS.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusS.TabIndex = 6;
            this.textBoxRadiusS.Text = "50";
            // 
            // lblRadiusS
            // 
            this.lblRadiusS.AutoSize = true;
            this.lblRadiusS.Location = new System.Drawing.Point(41, 188);
            this.lblRadiusS.Name = "lblRadiusS";
            this.lblRadiusS.Size = new System.Drawing.Size(40, 13);
            this.lblRadiusS.TabIndex = 19;
            this.lblRadiusS.Text = "Radius";
            // 
            // PointCloudGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 386);
            this.Controls.Add(this.textBoxRadiusS);
            this.Controls.Add(this.lblRadiusS);
            this.Controls.Add(this.textBoxRadiusC);
            this.Controls.Add(this.lblRadiusC);
            this.Controls.Add(this.textBoxLambdaToS);
            this.Controls.Add(this.textBoxLambdaFromS);
            this.Controls.Add(this.textBoxThetaToS);
            this.Controls.Add(this.textBoxThetaFromS);
            this.Controls.Add(this.textBoxZStartS);
            this.Controls.Add(this.textBoxThetaToC);
            this.Controls.Add(this.textBoxThetaFromC);
            this.Controls.Add(this.textBoxZToC);
            this.Controls.Add(this.textBoxZFromC);
            this.Controls.Add(this.lblLambdaToS);
            this.Controls.Add(this.lblLambdaFromS);
            this.Controls.Add(this.lblThetaToS);
            this.Controls.Add(this.lblThetaFromS);
            this.Controls.Add(this.lblZStartS);
            this.Controls.Add(this.lblThetaToC);
            this.Controls.Add(this.lblThetaFromC);
            this.Controls.Add(this.lblZToC);
            this.Controls.Add(this.lblZFromC);
            this.Controls.Add(this.lblGenSphere);
            this.Controls.Add(this.lblGenCylinder);
            this.Controls.Add(this.gtnGen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 425);
            this.MinimumSize = new System.Drawing.Size(350, 425);
            this.Name = "PointCloudGenForm";
            this.Text = "Point Cloud Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PointCloudGenForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gtnGen;
        private System.Windows.Forms.Label lblGenCylinder;
        private System.Windows.Forms.Label lblGenSphere;
        private System.Windows.Forms.Label lblZFromC;
        private System.Windows.Forms.Label lblZToC;
        private System.Windows.Forms.Label lblThetaToC;
        private System.Windows.Forms.Label lblThetaFromC;
        private System.Windows.Forms.Label lblThetaToS;
        private System.Windows.Forms.Label lblThetaFromS;
        private System.Windows.Forms.Label lblZStartS;
        private System.Windows.Forms.Label lblLambdaToS;
        private System.Windows.Forms.Label lblLambdaFromS;
        private System.Windows.Forms.TextBox textBoxZFromC;
        private System.Windows.Forms.TextBox textBoxZToC;
        private System.Windows.Forms.TextBox textBoxThetaToC;
        private System.Windows.Forms.TextBox textBoxThetaFromC;
        private System.Windows.Forms.TextBox textBoxZStartS;
        private System.Windows.Forms.TextBox textBoxThetaToS;
        private System.Windows.Forms.TextBox textBoxThetaFromS;
        private System.Windows.Forms.TextBox textBoxLambdaToS;
        private System.Windows.Forms.TextBox textBoxLambdaFromS;
        private System.Windows.Forms.TextBox textBoxRadiusC;
        private System.Windows.Forms.Label lblRadiusC;
        private System.Windows.Forms.TextBox textBoxRadiusS;
        private System.Windows.Forms.Label lblRadiusS;
    }
}