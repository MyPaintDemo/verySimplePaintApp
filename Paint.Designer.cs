namespace ProjectPaint
{
    partial class Paint
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
            this.Draw_Line = new System.Windows.Forms.Button();
            this.Abstract_Line = new System.Windows.Forms.Button();
            this.Overlapping_Line = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Overlapping_Ellipse = new System.Windows.Forms.Button();
            this.Overlapping_Circle = new System.Windows.Forms.Button();
            this.Overlapping_Rectangle = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Fuchsia = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Brown = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.House = new System.Windows.Forms.Button();
            this.Car = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Clean_All = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Draw_Line
            // 
            this.Draw_Line.Location = new System.Drawing.Point(985, 27);
            this.Draw_Line.Name = "Draw_Line";
            this.Draw_Line.Size = new System.Drawing.Size(170, 58);
            this.Draw_Line.TabIndex = 0;
            this.Draw_Line.Text = "Straight Line";
            this.Draw_Line.UseVisualStyleBackColor = true;
            this.Draw_Line.Click += new System.EventHandler(this.Draw_Line_Click);
            // 
            // Abstract_Line
            // 
            this.Abstract_Line.Location = new System.Drawing.Point(985, 106);
            this.Abstract_Line.Name = "Abstract_Line";
            this.Abstract_Line.Size = new System.Drawing.Size(170, 58);
            this.Abstract_Line.TabIndex = 6;
            this.Abstract_Line.Text = "Abstract Line";
            this.Abstract_Line.UseVisualStyleBackColor = true;
            this.Abstract_Line.Click += new System.EventHandler(this.Abstract_Line_Click);
            // 
            // Overlapping_Line
            // 
            this.Overlapping_Line.Location = new System.Drawing.Point(1161, 27);
            this.Overlapping_Line.Name = "Overlapping_Line";
            this.Overlapping_Line.Size = new System.Drawing.Size(170, 58);
            this.Overlapping_Line.TabIndex = 7;
            this.Overlapping_Line.Text = "Overlapping Line";
            this.Overlapping_Line.UseVisualStyleBackColor = true;
            this.Overlapping_Line.Click += new System.EventHandler(this.Overlapping_Line_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(985, 175);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(170, 58);
            this.Rectangle.TabIndex = 8;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(985, 253);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(170, 58);
            this.Circle.TabIndex = 10;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(985, 333);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(170, 58);
            this.Ellipse.TabIndex = 11;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(1273, 419);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Overlapping_Ellipse
            // 
            this.Overlapping_Ellipse.Location = new System.Drawing.Point(1166, 333);
            this.Overlapping_Ellipse.Name = "Overlapping_Ellipse";
            this.Overlapping_Ellipse.Size = new System.Drawing.Size(170, 58);
            this.Overlapping_Ellipse.TabIndex = 18;
            this.Overlapping_Ellipse.Text = "Overlapping Ellipse";
            this.Overlapping_Ellipse.UseVisualStyleBackColor = true;
            this.Overlapping_Ellipse.Click += new System.EventHandler(this.Overlapping_Ellipse_Click);
            // 
            // Overlapping_Circle
            // 
            this.Overlapping_Circle.Location = new System.Drawing.Point(1166, 253);
            this.Overlapping_Circle.Name = "Overlapping_Circle";
            this.Overlapping_Circle.Size = new System.Drawing.Size(170, 58);
            this.Overlapping_Circle.TabIndex = 17;
            this.Overlapping_Circle.Text = "Overlapping Circle";
            this.Overlapping_Circle.UseVisualStyleBackColor = true;
            this.Overlapping_Circle.Click += new System.EventHandler(this.Overlapping_Circle_Click);
            // 
            // Overlapping_Rectangle
            // 
            this.Overlapping_Rectangle.Location = new System.Drawing.Point(1166, 175);
            this.Overlapping_Rectangle.Name = "Overlapping_Rectangle";
            this.Overlapping_Rectangle.Size = new System.Drawing.Size(170, 58);
            this.Overlapping_Rectangle.TabIndex = 16;
            this.Overlapping_Rectangle.Text = "Overlapping Rectangle";
            this.Overlapping_Rectangle.UseVisualStyleBackColor = true;
            this.Overlapping_Rectangle.Click += new System.EventHandler(this.Overlapping_Rectangle_Click);
            // 
            // Eraser
            // 
            this.Eraser.Location = new System.Drawing.Point(1161, 106);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(170, 58);
            this.Eraser.TabIndex = 19;
            this.Eraser.Text = "Eraser";
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(1132, 397);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(41, 38);
            this.Red.TabIndex = 20;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(1132, 441);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(41, 38);
            this.Green.TabIndex = 21;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(1132, 485);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(41, 38);
            this.Blue.TabIndex = 22;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(1179, 397);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(41, 38);
            this.Yellow.TabIndex = 23;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Fuchsia
            // 
            this.Fuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.Fuchsia.Location = new System.Drawing.Point(1179, 441);
            this.Fuchsia.Name = "Fuchsia";
            this.Fuchsia.Size = new System.Drawing.Size(41, 38);
            this.Fuchsia.TabIndex = 24;
            this.Fuchsia.UseVisualStyleBackColor = false;
            this.Fuchsia.Click += new System.EventHandler(this.Fuchsia_Click);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(1179, 485);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(41, 38);
            this.Aqua.TabIndex = 25;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.Click += new System.EventHandler(this.Aqua_Click);
            // 
            // Brown
            // 
            this.Brown.BackColor = System.Drawing.Color.Brown;
            this.Brown.Location = new System.Drawing.Point(1226, 485);
            this.Brown.Name = "Brown";
            this.Brown.Size = new System.Drawing.Size(41, 38);
            this.Brown.TabIndex = 28;
            this.Brown.UseVisualStyleBackColor = false;
            this.Brown.Click += new System.EventHandler(this.Brown_Click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(1226, 441);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(41, 38);
            this.White.TabIndex = 27;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.White_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(1226, 397);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(41, 38);
            this.Black.TabIndex = 26;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(985, 397);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(68, 58);
            this.House.TabIndex = 29;
            this.House.Text = "Draw House";
            this.House.UseVisualStyleBackColor = true;
            this.House.Click += new System.EventHandler(this.House_Click);
            // 
            // Car
            // 
            this.Car.Location = new System.Drawing.Point(985, 465);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(68, 58);
            this.Car.TabIndex = 30;
            this.Car.Text = "Draw Car";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Clean_All
            // 
            this.Clean_All.Location = new System.Drawing.Point(1059, 397);
            this.Clean_All.Name = "Clean_All";
            this.Clean_All.Size = new System.Drawing.Size(68, 58);
            this.Clean_All.TabIndex = 31;
            this.Clean_All.Text = "Clean All";
            this.Clean_All.UseVisualStyleBackColor = true;
            this.Clean_All.Click += new System.EventHandler(this.Clean_All_Click);
            // 
            // Words
            // 
            this.Words.Location = new System.Drawing.Point(1059, 465);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(68, 58);
            this.Words.TabIndex = 32;
            this.Words.Text = "Draw Words";
            this.Words.UseVisualStyleBackColor = true;
            this.Words.Click += new System.EventHandler(this.Words_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Perpetua",
            "Arial",
            "Rockwell",
            "Showcard Gothic"});
            this.comboBox2.Location = new System.Drawing.Point(1273, 462);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(54, 21);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1273, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pen Size";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1273, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fonts";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.Clean_All);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Brown);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Fuchsia);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.Overlapping_Ellipse);
            this.Controls.Add(this.Overlapping_Circle);
            this.Controls.Add(this.Overlapping_Rectangle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Overlapping_Line);
            this.Controls.Add(this.Abstract_Line);
            this.Controls.Add(this.Draw_Line);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Draw_Line;
        private System.Windows.Forms.Button Abstract_Line;
        private System.Windows.Forms.Button Overlapping_Line;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Overlapping_Ellipse;
        private System.Windows.Forms.Button Overlapping_Circle;
        private System.Windows.Forms.Button Overlapping_Rectangle;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Fuchsia;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Brown;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button House;
        private System.Windows.Forms.Button Car;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Clean_All;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button Words;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

