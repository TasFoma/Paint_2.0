namespace Paint_2._0
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
            panel1 = new Panel();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            btn_color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.YellowGreen;
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_rect);
            panel1.Controls.Add(btn_ellipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 120);
            panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(0, -1);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(202, 118);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.YellowGreen;
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_line.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(733, 27);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(72, 65);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.YellowGreen;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(655, 27);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(72, 65);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.YellowGreen;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(577, 27);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(72, 65);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.YellowGreen;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eraser.Location = new Point(499, 27);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(72, 65);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.YellowGreen;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pencil.Location = new Point(421, 27);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(72, 65);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.YellowGreen;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fill.Location = new Point(343, 27);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(72, 65);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(208, 39);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(41, 41);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(btn_color);
            panel3.Location = new Point(255, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(559, 94);
            panel3.TabIndex = 8;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.YellowGreen;
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_color.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.color;
            btn_color.ImageAlign = ContentAlignment.MiddleLeft;
            btn_color.Location = new Point(10, 15);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(72, 65);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.YellowGreen;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 492);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 19);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(864, 511);
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button pic_color;
        private Button btn_color;
        private Button btn_fill;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_line;
        private Button btn_rect;
        private Panel panel3;
        private PictureBox color_picker;
    }
}
