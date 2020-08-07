namespace Area_point
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExe = new System.Windows.Forms.Button();
            this.btnPtnGen = new System.Windows.Forms.Button();
            this.btnModGen = new System.Windows.Forms.Button();
            this.btnVolumeCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExe
            // 
            this.btnExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnExe.Location = new System.Drawing.Point(12, 12);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(260, 30);
            this.btnExe.TabIndex = 0;
            this.btnExe.Text = "Point Cloud Viewer";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.BtnExe_Click);
            // 
            // btnPtnGen
            // 
            this.btnPtnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnPtnGen.Location = new System.Drawing.Point(12, 48);
            this.btnPtnGen.Name = "btnPtnGen";
            this.btnPtnGen.Size = new System.Drawing.Size(260, 30);
            this.btnPtnGen.TabIndex = 1;
            this.btnPtnGen.Text = "Point Cloud Generator";
            this.btnPtnGen.UseVisualStyleBackColor = true;
            this.btnPtnGen.Click += new System.EventHandler(this.BtnPtnGen_Click);
            // 
            // btnModGen
            // 
            this.btnModGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnModGen.Location = new System.Drawing.Point(12, 84);
            this.btnModGen.Name = "btnModGen";
            this.btnModGen.Size = new System.Drawing.Size(260, 30);
            this.btnModGen.TabIndex = 2;
            this.btnModGen.Text = "Model Generator";
            this.btnModGen.UseVisualStyleBackColor = true;
            this.btnModGen.Click += new System.EventHandler(this.BtnModGen_Click);
            // 
            // btnVolumeCal
            // 
            this.btnVolumeCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnVolumeCal.Location = new System.Drawing.Point(12, 120);
            this.btnVolumeCal.Name = "btnVolumeCal";
            this.btnVolumeCal.Size = new System.Drawing.Size(260, 30);
            this.btnVolumeCal.TabIndex = 3;
            this.btnVolumeCal.Text = "Volume Calculator";
            this.btnVolumeCal.UseVisualStyleBackColor = true;
            this.btnVolumeCal.Click += new System.EventHandler(this.BtnVolumeCal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVolumeCal);
            this.Controls.Add(this.btnModGen);
            this.Controls.Add(this.btnPtnGen);
            this.Controls.Add(this.btnExe);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Button btnPtnGen;
        private System.Windows.Forms.Button btnModGen;
        private System.Windows.Forms.Button btnVolumeCal;
    }
}