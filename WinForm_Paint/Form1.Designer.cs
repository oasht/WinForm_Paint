
namespace WinForm_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_Ellipse = new System.Windows.Forms.Button();
            this.button_pen = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 602);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_eraser);
            this.groupBox1.Controls.Add(this.button_color);
            this.groupBox1.Controls.Add(this.button_line);
            this.groupBox1.Controls.Add(this.button_Ellipse);
            this.groupBox1.Controls.Add(this.button_pen);
            this.groupBox1.Controls.Add(this.button_rectangle);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор толщины";
            // 
            // button_eraser
            // 
            this.button_eraser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_eraser.BackgroundImage")));
            this.button_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_eraser.Location = new System.Drawing.Point(781, 21);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_eraser.Size = new System.Drawing.Size(79, 79);
            this.button_eraser.TabIndex = 2;
            this.button_eraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_eraser.UseVisualStyleBackColor = true;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_color
            // 
            this.button_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_color.BackgroundImage")));
            this.button_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_color.Location = new System.Drawing.Point(696, 22);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(79, 79);
            this.button_color.TabIndex = 2;
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_line
            // 
            this.button_line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_line.BackgroundImage")));
            this.button_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_line.Location = new System.Drawing.Point(611, 21);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(79, 79);
            this.button_line.TabIndex = 2;
            this.button_line.UseVisualStyleBackColor = true;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_Ellipse
            // 
            this.button_Ellipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Ellipse.BackgroundImage")));
            this.button_Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Ellipse.Location = new System.Drawing.Point(530, 22);
            this.button_Ellipse.Name = "button_Ellipse";
            this.button_Ellipse.Size = new System.Drawing.Size(79, 79);
            this.button_Ellipse.TabIndex = 2;
            this.button_Ellipse.UseVisualStyleBackColor = true;
            this.button_Ellipse.Click += new System.EventHandler(this.button_Ellipse_Click);
            // 
            // button_pen
            // 
            this.button_pen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_pen.BackgroundImage")));
            this.button_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_pen.Location = new System.Drawing.Point(368, 22);
            this.button_pen.Name = "button_pen";
            this.button_pen.Size = new System.Drawing.Size(79, 79);
            this.button_pen.TabIndex = 2;
            this.button_pen.UseVisualStyleBackColor = false;
            this.button_pen.Click += new System.EventHandler(this.button_pen_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_rectangle.BackgroundImage")));
            this.button_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_rectangle.Location = new System.Drawing.Point(449, 22);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(79, 79);
            this.button_rectangle.TabIndex = 2;
            this.button_rectangle.UseVisualStyleBackColor = false;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(88, 50);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(269, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(7, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 79);
            this.panel2.TabIndex = 0;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 602);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_Ellipse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_pen;
    }
}

