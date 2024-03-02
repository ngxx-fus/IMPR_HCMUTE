namespace MN_05
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picBoxHinhGoc = new System.Windows.Forms.PictureBox();
            this.lblHinhGoc = new System.Windows.Forms.Label();
            this.picBoxHinhMucXam = new System.Windows.Forms.PictureBox();
            this.lblHinhXam = new System.Windows.Forms.Label();
            this.zGHistogram = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhMucXam)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxHinhGoc
            // 
            this.picBoxHinhGoc.Location = new System.Drawing.Point(41, 50);
            this.picBoxHinhGoc.Name = "picBoxHinhGoc";
            this.picBoxHinhGoc.Size = new System.Drawing.Size(320, 323);
            this.picBoxHinhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHinhGoc.TabIndex = 0;
            this.picBoxHinhGoc.TabStop = false;
            this.picBoxHinhGoc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblHinhGoc
            // 
            this.lblHinhGoc.AutoSize = true;
            this.lblHinhGoc.Location = new System.Drawing.Point(38, 34);
            this.lblHinhGoc.Name = "lblHinhGoc";
            this.lblHinhGoc.Size = new System.Drawing.Size(58, 13);
            this.lblHinhGoc.TabIndex = 2;
            this.lblHinhGoc.Text = "Hình Gốc: ";
            this.lblHinhGoc.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBoxHinhMucXam
            // 
            this.picBoxHinhMucXam.Location = new System.Drawing.Point(41, 424);
            this.picBoxHinhMucXam.Name = "picBoxHinhMucXam";
            this.picBoxHinhMucXam.Size = new System.Drawing.Size(320, 303);
            this.picBoxHinhMucXam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxHinhMucXam.TabIndex = 3;
            this.picBoxHinhMucXam.TabStop = false;
            // 
            // lblHinhXam
            // 
            this.lblHinhXam.AutoSize = true;
            this.lblHinhXam.Location = new System.Drawing.Point(38, 396);
            this.lblHinhXam.Name = "lblHinhXam";
            this.lblHinhXam.Size = new System.Drawing.Size(53, 13);
            this.lblHinhXam.TabIndex = 4;
            this.lblHinhXam.Text = "Hình Xám";
            this.lblHinhXam.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // zGHistogram
            // 
            this.zGHistogram.Location = new System.Drawing.Point(383, 34);
            this.zGHistogram.Name = "zGHistogram";
            this.zGHistogram.ScrollGrace = 0D;
            this.zGHistogram.ScrollMaxX = 0D;
            this.zGHistogram.ScrollMaxY = 0D;
            this.zGHistogram.ScrollMaxY2 = 0D;
            this.zGHistogram.ScrollMinX = 0D;
            this.zGHistogram.ScrollMinY = 0D;
            this.zGHistogram.ScrollMinY2 = 0D;
            this.zGHistogram.Size = new System.Drawing.Size(940, 660);
            this.zGHistogram.TabIndex = 5;
            this.zGHistogram.UseExtendedPrintDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.zGHistogram);
            this.Controls.Add(this.lblHinhXam);
            this.Controls.Add(this.picBoxHinhMucXam);
            this.Controls.Add(this.lblHinhGoc);
            this.Controls.Add(this.picBoxHinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHinhMucXam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHinhGoc;
        private System.Windows.Forms.Label lblHinhGoc;
        private System.Windows.Forms.PictureBox picBoxHinhMucXam;
        private System.Windows.Forms.Label lblHinhXam;
        private ZedGraph.ZedGraphControl zGHistogram;
    }
}

