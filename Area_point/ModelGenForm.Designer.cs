namespace Area_point
{
    partial class ModelGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelGenForm));
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxThetaStepSize = new System.Windows.Forms.TextBox();
            this.textBoxZfromC = new System.Windows.Forms.TextBox();
            this.textBoxZToC = new System.Windows.Forms.TextBox();
            this.textBoxZStepSizeC = new System.Windows.Forms.TextBox();
            this.textBoxLambdaStepSizeS = new System.Windows.Forms.TextBox();
            this.gtnGen = new System.Windows.Forms.Button();
            this.lblGenSphere = new System.Windows.Forms.Label();
            this.lblGenCylinder = new System.Windows.Forms.Label();
            this.lblZToC = new System.Windows.Forms.Label();
            this.lblZFromC = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblThetaStepSize = new System.Windows.Forms.Label();
            this.lblZStepSize = new System.Windows.Forms.Label();
            this.lblLambdaStepSize = new System.Windows.Forms.Label();
            this.linklblOpenModel = new System.Windows.Forms.LinkLabel();
            this.checkBoxNoise = new System.Windows.Forms.CheckBox();
            this.comboBoxPercentage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(111, 25);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadius.TabIndex = 1;
            this.textBoxRadius.Text = "100";
            // 
            // textBoxThetaStepSize
            // 
            this.textBoxThetaStepSize.Location = new System.Drawing.Point(111, 62);
            this.textBoxThetaStepSize.Name = "textBoxThetaStepSize";
            this.textBoxThetaStepSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxThetaStepSize.TabIndex = 2;
            this.textBoxThetaStepSize.Text = "22.5";
            // 
            // textBoxZfromC
            // 
            this.textBoxZfromC.Location = new System.Drawing.Point(111, 146);
            this.textBoxZfromC.Name = "textBoxZfromC";
            this.textBoxZfromC.Size = new System.Drawing.Size(100, 20);
            this.textBoxZfromC.TabIndex = 3;
            this.textBoxZfromC.Text = "0";
            // 
            // textBoxZToC
            // 
            this.textBoxZToC.Location = new System.Drawing.Point(250, 146);
            this.textBoxZToC.Name = "textBoxZToC";
            this.textBoxZToC.Size = new System.Drawing.Size(100, 20);
            this.textBoxZToC.TabIndex = 4;
            this.textBoxZToC.Text = "50";
            // 
            // textBoxZStepSizeC
            // 
            this.textBoxZStepSizeC.Location = new System.Drawing.Point(111, 187);
            this.textBoxZStepSizeC.Name = "textBoxZStepSizeC";
            this.textBoxZStepSizeC.Size = new System.Drawing.Size(100, 20);
            this.textBoxZStepSizeC.TabIndex = 5;
            this.textBoxZStepSizeC.Text = "10";
            // 
            // textBoxLambdaStepSizeS
            // 
            this.textBoxLambdaStepSizeS.Location = new System.Drawing.Point(111, 277);
            this.textBoxLambdaStepSizeS.Name = "textBoxLambdaStepSizeS";
            this.textBoxLambdaStepSizeS.Size = new System.Drawing.Size(100, 20);
            this.textBoxLambdaStepSizeS.TabIndex = 6;
            this.textBoxLambdaStepSizeS.Text = "22.5";
            // 
            // gtnGen
            // 
            this.gtnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtnGen.Location = new System.Drawing.Point(12, 316);
            this.gtnGen.Name = "gtnGen";
            this.gtnGen.Size = new System.Drawing.Size(343, 34);
            this.gtnGen.TabIndex = 7;
            this.gtnGen.Text = "Generate Point Cloude And OBJ Model";
            this.gtnGen.UseVisualStyleBackColor = true;
            this.gtnGen.Click += new System.EventHandler(this.GtnGen_Click);
            // 
            // lblGenSphere
            // 
            this.lblGenSphere.AutoSize = true;
            this.lblGenSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenSphere.Location = new System.Drawing.Point(98, 237);
            this.lblGenSphere.Name = "lblGenSphere";
            this.lblGenSphere.Size = new System.Drawing.Size(133, 17);
            this.lblGenSphere.TabIndex = 14;
            this.lblGenSphere.Text = "Generate Sphere";
            // 
            // lblGenCylinder
            // 
            this.lblGenCylinder.AutoSize = true;
            this.lblGenCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenCylinder.Location = new System.Drawing.Point(91, 110);
            this.lblGenCylinder.Name = "lblGenCylinder";
            this.lblGenCylinder.Size = new System.Drawing.Size(140, 17);
            this.lblGenCylinder.TabIndex = 15;
            this.lblGenCylinder.Text = "Generate Cylinder";
            // 
            // lblZToC
            // 
            this.lblZToC.AutoSize = true;
            this.lblZToC.Location = new System.Drawing.Point(219, 149);
            this.lblZToC.Name = "lblZToC";
            this.lblZToC.Size = new System.Drawing.Size(20, 13);
            this.lblZToC.TabIndex = 18;
            this.lblZToC.Text = "To";
            // 
            // lblZFromC
            // 
            this.lblZFromC.AutoSize = true;
            this.lblZFromC.Location = new System.Drawing.Point(12, 149);
            this.lblZFromC.Name = "lblZFromC";
            this.lblZFromC.Size = new System.Drawing.Size(40, 13);
            this.lblZFromC.TabIndex = 17;
            this.lblZFromC.Text = "Z From";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(12, 25);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 20;
            this.lblRadius.Text = "Radius";
            // 
            // lblThetaStepSize
            // 
            this.lblThetaStepSize.AutoSize = true;
            this.lblThetaStepSize.Location = new System.Drawing.Point(12, 65);
            this.lblThetaStepSize.Name = "lblThetaStepSize";
            this.lblThetaStepSize.Size = new System.Drawing.Size(83, 13);
            this.lblThetaStepSize.TabIndex = 21;
            this.lblThetaStepSize.Text = "Theta Step Size";
            // 
            // lblZStepSize
            // 
            this.lblZStepSize.AutoSize = true;
            this.lblZStepSize.Location = new System.Drawing.Point(12, 190);
            this.lblZStepSize.Name = "lblZStepSize";
            this.lblZStepSize.Size = new System.Drawing.Size(62, 13);
            this.lblZStepSize.TabIndex = 22;
            this.lblZStepSize.Text = "Z Step Size";
            // 
            // lblLambdaStepSize
            // 
            this.lblLambdaStepSize.AutoSize = true;
            this.lblLambdaStepSize.Location = new System.Drawing.Point(12, 280);
            this.lblLambdaStepSize.Name = "lblLambdaStepSize";
            this.lblLambdaStepSize.Size = new System.Drawing.Size(93, 13);
            this.lblLambdaStepSize.TabIndex = 23;
            this.lblLambdaStepSize.Text = "Lambda Step Size";
            // 
            // linklblOpenModel
            // 
            this.linklblOpenModel.AutoSize = true;
            this.linklblOpenModel.Location = new System.Drawing.Point(268, 364);
            this.linklblOpenModel.Name = "linklblOpenModel";
            this.linklblOpenModel.Size = new System.Drawing.Size(82, 13);
            this.linklblOpenModel.TabIndex = 24;
            this.linklblOpenModel.TabStop = true;
            this.linklblOpenModel.Text = "Open 3D Model";
            this.linklblOpenModel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinklblOpenModel_LinkClicked);
            // 
            // checkBoxNoise
            // 
            this.checkBoxNoise.AutoSize = true;
            this.checkBoxNoise.Location = new System.Drawing.Point(236, 27);
            this.checkBoxNoise.Name = "checkBoxNoise";
            this.checkBoxNoise.Size = new System.Drawing.Size(53, 17);
            this.checkBoxNoise.TabIndex = 25;
            this.checkBoxNoise.Text = "Noise";
            this.checkBoxNoise.UseVisualStyleBackColor = true;
            this.checkBoxNoise.CheckedChanged += new System.EventHandler(this.CheckBoxNoise_CheckedChanged);
            // 
            // comboBoxPercentage
            // 
            this.comboBoxPercentage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPercentage.Enabled = false;
            this.comboBoxPercentage.FormattingEnabled = true;
            this.comboBoxPercentage.Location = new System.Drawing.Point(293, 25);
            this.comboBoxPercentage.Name = "comboBoxPercentage";
            this.comboBoxPercentage.Size = new System.Drawing.Size(62, 21);
            this.comboBoxPercentage.TabIndex = 26;
            // 
            // ModelGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 386);
            this.Controls.Add(this.comboBoxPercentage);
            this.Controls.Add(this.checkBoxNoise);
            this.Controls.Add(this.linklblOpenModel);
            this.Controls.Add(this.lblLambdaStepSize);
            this.Controls.Add(this.lblZStepSize);
            this.Controls.Add(this.lblThetaStepSize);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblZToC);
            this.Controls.Add(this.lblZFromC);
            this.Controls.Add(this.lblGenSphere);
            this.Controls.Add(this.lblGenCylinder);
            this.Controls.Add(this.gtnGen);
            this.Controls.Add(this.textBoxLambdaStepSizeS);
            this.Controls.Add(this.textBoxZStepSizeC);
            this.Controls.Add(this.textBoxZToC);
            this.Controls.Add(this.textBoxZfromC);
            this.Controls.Add(this.textBoxThetaStepSize);
            this.Controls.Add(this.textBoxRadius);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 425);
            this.MinimumSize = new System.Drawing.Size(380, 425);
            this.Name = "ModelGenForm";
            this.Text = "Model Generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelGenForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.TextBox textBoxThetaStepSize;
        private System.Windows.Forms.TextBox textBoxZfromC;
        private System.Windows.Forms.TextBox textBoxZToC;
        private System.Windows.Forms.TextBox textBoxZStepSizeC;
        private System.Windows.Forms.TextBox textBoxLambdaStepSizeS;
        private System.Windows.Forms.Button gtnGen;
        private System.Windows.Forms.Label lblGenSphere;
        private System.Windows.Forms.Label lblGenCylinder;
        private System.Windows.Forms.Label lblZToC;
        private System.Windows.Forms.Label lblZFromC;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblThetaStepSize;
        private System.Windows.Forms.Label lblZStepSize;
        private System.Windows.Forms.Label lblLambdaStepSize;
        private System.Windows.Forms.LinkLabel linklblOpenModel;
        private System.Windows.Forms.CheckBox checkBoxNoise;
        private System.Windows.Forms.ComboBox comboBoxPercentage;
    }
}