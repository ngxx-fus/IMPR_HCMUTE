namespace RGB_Channels_Splitter
{
    partial class Main_Form
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
            image_path_label = new Label();
            textBox1 = new TextBox();
            load_button = new Button();
            original_picture_box = new PictureBox();
            red_channel_picture_box = new PictureBox();
            green_channel_picture_box = new PictureBox();
            blue_channel_picture_box = new PictureBox();
            Original_Label = new Label();
            Red_Label = new Label();
            Green_Label = new Label();
            Blue_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)original_picture_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)red_channel_picture_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)green_channel_picture_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blue_channel_picture_box).BeginInit();
            SuspendLayout();
            // 
            // image_path_label
            // 
            image_path_label.AutoSize = true;
            image_path_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            image_path_label.Location = new Point(28, 18);
            image_path_label.Name = "image_path_label";
            image_path_label.Size = new Size(73, 15);
            image_path_label.TabIndex = 0;
            image_path_label.Text = "Image path:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Enter path to an image!";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // load_button
            // 
            load_button.Location = new Point(417, 36);
            load_button.Name = "load_button";
            load_button.Size = new Size(75, 23);
            load_button.TabIndex = 2;
            load_button.Text = "load";
            load_button.UseVisualStyleBackColor = true;
            load_button.Click += button1_Click;
            // 
            // original_picture_box
            // 
            original_picture_box.Location = new Point(28, 97);
            original_picture_box.Name = "original_picture_box";
            original_picture_box.Size = new Size(276, 222);
            original_picture_box.TabIndex = 3;
            original_picture_box.TabStop = false;
            // 
            // red_channel_picture_box
            // 
            red_channel_picture_box.Location = new Point(352, 97);
            red_channel_picture_box.Name = "red_channel_picture_box";
            red_channel_picture_box.Size = new Size(276, 222);
            red_channel_picture_box.TabIndex = 4;
            red_channel_picture_box.TabStop = false;
            // 
            // green_channel_picture_box
            // 
            green_channel_picture_box.Location = new Point(28, 358);
            green_channel_picture_box.Name = "green_channel_picture_box";
            green_channel_picture_box.Size = new Size(276, 222);
            green_channel_picture_box.TabIndex = 5;
            green_channel_picture_box.TabStop = false;
            // 
            // blue_channel_picture_box
            // 
            blue_channel_picture_box.Location = new Point(352, 358);
            blue_channel_picture_box.Name = "blue_channel_picture_box";
            blue_channel_picture_box.Size = new Size(276, 222);
            blue_channel_picture_box.TabIndex = 6;
            blue_channel_picture_box.TabStop = false;
            // 
            // Original_Label
            // 
            Original_Label.AutoSize = true;
            Original_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Original_Label.Location = new Point(28, 79);
            Original_Label.Name = "Original_Label";
            Original_Label.Size = new Size(53, 15);
            Original_Label.TabIndex = 7;
            Original_Label.Text = "Original:";
            Original_Label.Click += Label1_Click;
            // 
            // Red_Label
            // 
            Red_Label.AutoSize = true;
            Red_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Red_Label.Location = new Point(352, 79);
            Red_Label.Name = "Red_Label";
            Red_Label.Size = new Size(32, 15);
            Red_Label.TabIndex = 8;
            Red_Label.Text = "Red:";
            Red_Label.Click += label2_Click;
            // 
            // Green_Label
            // 
            Green_Label.AutoSize = true;
            Green_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Green_Label.Location = new Point(28, 340);
            Green_Label.Name = "Green_Label";
            Green_Label.Size = new Size(45, 15);
            Green_Label.TabIndex = 9;
            Green_Label.Text = "Green:";
            // 
            // Blue_Label
            // 
            Blue_Label.AutoSize = true;
            Blue_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Blue_Label.Location = new Point(352, 340);
            Blue_Label.Name = "Blue_Label";
            Blue_Label.Size = new Size(35, 15);
            Blue_Label.TabIndex = 10;
            Blue_Label.Text = "Blue:";
            Blue_Label.Click += label4_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 602);
            Controls.Add(Blue_Label);
            Controls.Add(Green_Label);
            Controls.Add(Red_Label);
            Controls.Add(Original_Label);
            Controls.Add(blue_channel_picture_box);
            Controls.Add(green_channel_picture_box);
            Controls.Add(red_channel_picture_box);
            Controls.Add(original_picture_box);
            Controls.Add(load_button);
            Controls.Add(textBox1);
            Controls.Add(image_path_label);
            Name = "Main_Form";
            Text = "RGB Channels Splitter";
            Load += Main_Form_Load;
            ((System.ComponentModel.ISupportInitialize)original_picture_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)red_channel_picture_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)green_channel_picture_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)blue_channel_picture_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label image_path_label;
        private TextBox textBox1;
        private Button load_button;
        private PictureBox original_picture_box;
        private PictureBox red_channel_picture_box;
        private PictureBox green_channel_picture_box;
        private PictureBox blue_channel_picture_box;
        private Label Original_Label;
        private Label Red_Label;
        private Label Green_Label;
        private Label Blue_Label;
    }
}
