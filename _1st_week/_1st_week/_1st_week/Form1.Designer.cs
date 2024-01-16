namespace _1st_week
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Image_Box = new Emgu.CV.UI.ImageBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Image_Box).BeginInit();
            SuspendLayout();
            // 
            // Image_Box
            // 
            Image_Box.Location = new Point(12, 27);
            Image_Box.Name = "Image_Box";
            Image_Box.Size = new Size(281, 223);
            Image_Box.TabIndex = 2;
            Image_Box.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Using Image_Box";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(label2);
            Controls.Add(Image_Box);
            Name = "Form1";
            Text = "DisplayIMG";
            ((System.ComponentModel.ISupportInitialize)Image_Box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Emgu.CV.UI.ImageBox Image_Box;
        private Label label2;
    }
}
