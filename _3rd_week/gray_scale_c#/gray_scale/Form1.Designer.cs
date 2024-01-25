namespace gray_scale
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
            Original_Label = new Label();
            Average_Method = new Label();
            Lightness_Method = new Label();
            Luminance_Method = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            img_path = new Label();
            img_path_textbox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Original_Label
            // 
            Original_Label.AutoSize = true;
            Original_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Original_Label.Location = new Point(23, 64);
            Original_Label.Name = "Original_Label";
            Original_Label.Size = new Size(50, 15);
            Original_Label.TabIndex = 0;
            Original_Label.Text = "Original";
            Original_Label.Click += label1_Click;
            // 
            // Average_Method
            // 
            Average_Method.AutoSize = true;
            Average_Method.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Average_Method.Location = new Point(262, 64);
            Average_Method.Name = "Average_Method";
            Average_Method.Size = new Size(101, 15);
            Average_Method.TabIndex = 1;
            Average_Method.Text = "Average Method";
            // 
            // Lightness_Method
            // 
            Lightness_Method.AutoSize = true;
            Lightness_Method.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lightness_Method.Location = new Point(23, 229);
            Lightness_Method.Name = "Lightness_Method";
            Lightness_Method.Size = new Size(106, 15);
            Lightness_Method.TabIndex = 2;
            Lightness_Method.Text = "Lightness Method";
            // 
            // Luminance_Method
            // 
            Luminance_Method.AutoSize = true;
            Luminance_Method.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Luminance_Method.Location = new Point(262, 229);
            Luminance_Method.Name = "Luminance_Method";
            Luminance_Method.Size = new Size(114, 15);
            Luminance_Method.TabIndex = 3;
            Luminance_Method.Text = "Luminance Method";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(262, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(23, 247);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(168, 121);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(262, 247);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // img_path
            // 
            img_path.AutoSize = true;
            img_path.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            img_path.Location = new Point(23, 9);
            img_path.Name = "img_path";
            img_path.Size = new Size(70, 15);
            img_path.TabIndex = 8;
            img_path.Text = "Imgae path";
            // 
            // img_path_textbox
            // 
            img_path_textbox.Location = new Point(23, 27);
            img_path_textbox.Name = "img_path_textbox";
            img_path_textbox.Size = new Size(353, 23);
            img_path_textbox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(383, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 450);
            Controls.Add(button1);
            Controls.Add(img_path_textbox);
            Controls.Add(img_path);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Luminance_Method);
            Controls.Add(Lightness_Method);
            Controls.Add(Average_Method);
            Controls.Add(Original_Label);
            Name = "Form1";
            Text = "Gray scale";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Original_Label;
        private Label Average_Method;
        private Label Lightness_Method;
        private Label Luminance_Method;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label img_path;
        private TextBox img_path_textbox;
        private Button button1;
    }
}
