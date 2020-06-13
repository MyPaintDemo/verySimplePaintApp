using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace ProjectPaint
{
    public partial class Paint : Form
    {

        Graphics PaintGraph;
        Pen PaintPen;
        Pen PaintEraser;
        SolidBrush myBrush;
        SolidBrush stringBrush;
        Font drawFont;

        static Boolean straightLineDraw = false;
        static Boolean abstractLineDraw = false;
        static Boolean overlappingLineDraw = false;
        static Boolean rectangleDraw = false;
        static Boolean circleDraw = false;
        static Boolean ellipseDraw = false;
        static Boolean overlappingRectangleDraw = false;
        static Boolean overlappingCircleDraw = false;
        static Boolean overlappingEllipseDraw = false;
        static Boolean eraser = false;


        static int DrawLine_Starting_X;
        static int DrawLine_Starting_Y;
        static int DrawLine_Previous_X;
        static int DrawLine_Previous_Y;

        static int index = 0;
        static string _font;
        Random _random_X_Y;

        List<int[]> ticker_draws = new List<int[]>();

        List<string> ticker_string_draws = new List<string>();




        public Paint()
        {
            InitializeComponent();
        }

        private void house_builder()
        {
            //Floor
            ticker_draws.Add(new int[] { 190, 540, 700, 540 });
            //Left side
            ticker_draws.Add(new int[] { 300, 540, 300, 400 });
            //Roof floor
            ticker_draws.Add(new int[] { 300, 400, 540, 400 });
            //Right side
            ticker_draws.Add(new int[] { 540, 400, 540, 540 });
            //Left roof
            ticker_draws.Add(new int[] { 300, 400, 420, 300 });
            //Right roof
            ticker_draws.Add(new int[] { 420, 300, 540, 400 });
            //Left side door
            ticker_draws.Add(new int[] { 420, 540, 420, 480 });
            //Top side door
            ticker_draws.Add(new int[] { 420, 480, 460, 480 });
            //Right side door
            ticker_draws.Add(new int[] { 460, 480, 460, 540 });
            //Left smoke
            ticker_draws.Add(new int[] { 480, 350, 480, 294 });
            //Top smoke
            ticker_draws.Add(new int[] { 480, 294, 520, 294 });
            //Right smoke
            ticker_draws.Add(new int[] { 520, 294, 520, 384 });
            //Down left sunshine
            ticker_draws.Add(new int[] { 570, 232, 610, 208 });
            //Top right sunshine
            ticker_draws.Add(new int[] { 732, 115, 775, 90 });
            //Top left sunshine
            ticker_draws.Add(new int[] { 583, 89, 620, 112 });
            //Down right sunshine
            ticker_draws.Add(new int[] { 730, 219, 763, 235 });
            //Window
            ticker_draws.Add(new int[] { 336, 418, 50, 50 });
            //Door knob
            ticker_draws.Add(new int[] { 451, 513, 3, 3 });
            //Sun
            ticker_draws.Add(new int[] { 615, 110, 110, 110 });

            //15, 3
        }

        private void car_builder()
        {
            //Car body 9 lines
            ticker_draws.Add(new int[] { 168, 485, 238, 485 });
            ticker_draws.Add(new int[] { 311, 485, 434, 485 });
            ticker_draws.Add(new int[] { 510, 485, 640, 485 });
            ticker_draws.Add(new int[] { 640, 485, 640, 430 });
            ticker_draws.Add(new int[] { 640, 430, 480, 430 });
            ticker_draws.Add(new int[] { 480, 430, 480, 380 });
            ticker_draws.Add(new int[] { 480, 380, 280, 380 });
            ticker_draws.Add(new int[] { 280, 380, 168, 435 });
            ticker_draws.Add(new int[] { 168, 435, 168, 485 });
            //Front windshield
            ticker_draws.Add(new int[] { 480, 380, 595, 430 });
            //Door
            ticker_draws.Add(new int[] { 373, 380, 373, 485 });
            //Left wheel
            ticker_draws.Add(new int[] { 235, 450, 75, 75 });
            ticker_draws.Add(new int[] { 270, 485, 5, 5 });
            //Right wheel
            ticker_draws.Add(new int[] { 435, 450, 75, 75 });
            ticker_draws.Add(new int[] { 470, 485, 5, 5 });

            //11, 4
        }

        private void word_builder()
        {
            ticker_string_draws.Add("zestfully");
            ticker_string_draws.Add("theory");
            ticker_string_draws.Add("scary");
            ticker_string_draws.Add("shock");
            ticker_string_draws.Add("gracefully");
            ticker_string_draws.Add("property");
            ticker_string_draws.Add("nest");
            ticker_string_draws.Add("joyfully");
            ticker_string_draws.Add("dust");
            ticker_string_draws.Add("awake");
            ticker_string_draws.Add("table");
            ticker_string_draws.Add("empty");
        }

        private void Paint_Load(object sender, EventArgs e)
        {

            PaintGraph = this.CreateGraphics();

            PaintPen = new Pen(Color.Black, 15);
            PaintEraser = new Pen(this.BackColor, PaintPen.Width);

            comboBox1.Text = PaintPen.Width.ToString();
            comboBox2.Text = "Arial";



        }



        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            if (straightLineDraw || abstractLineDraw || overlappingLineDraw || 
                rectangleDraw || circleDraw || ellipseDraw || overlappingRectangleDraw ||
                overlappingCircleDraw || overlappingEllipseDraw)
            {
                DrawLine_Starting_X = e.X;
                DrawLine_Starting_Y = e.Y;


            }


        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (abstractLineDraw)
            {
                
                Abstract_Line.Text = "X: " + e.X.ToString() + " , Y: " + e.Y.ToString();

                if (Control.MouseButtons.ToString() == "Left")
                {

                    PaintGraph.DrawLine(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, e.X, e.Y);

                    DrawLine_Starting_X = e.X;
                    DrawLine_Starting_Y = e.Y;

                }

            }
            else if (straightLineDraw)
            {
                Draw_Line.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\nX: " + e.X.ToString() + " , Y: " + e.Y.ToString();
            }
            else if (overlappingLineDraw)
            {
                Overlapping_Line.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\nX: " + e.X.ToString() + " , Y: " + e.Y.ToString() + "\nDO NOT OVERLAP LINES!";

                if (Control.MouseButtons.ToString() == "Left")
                {
                    
                    PaintGraph.DrawLine(PaintEraser, DrawLine_Starting_X, DrawLine_Starting_Y, DrawLine_Previous_X, DrawLine_Previous_Y);
                    PaintGraph.DrawLine(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, e.X, e.Y);

                    DrawLine_Previous_X = e.X;
                    DrawLine_Previous_Y = e.Y;

                }
            }
            else if (rectangleDraw)
            {
                Rectangle.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\n X: " + e.X.ToString() + " , Y: " + e.Y.ToString();
            }
            else if (circleDraw)
            {
                Circle.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\n X: " + e.X.ToString() + " , Y: " + e.Y.ToString();
            }
            else if (ellipseDraw)
            {
                Ellipse.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\n X: " + e.X.ToString() + " , Y: " + e.Y.ToString();
            }
            else if (overlappingRectangleDraw)
            {
                Overlapping_Rectangle.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\nX: " + e.X.ToString() + " , Y: " + e.Y.ToString() + "\nDO NOT OVERLAP LINES!";

                if (Control.MouseButtons.ToString() == "Left")
                {

                    PaintGraph.DrawRectangle(PaintEraser, DrawLine_Starting_X, DrawLine_Starting_Y, DrawLine_Previous_X, DrawLine_Previous_Y);
                    PaintGraph.DrawRectangle(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, (e.X - DrawLine_Starting_X), (e.Y - DrawLine_Starting_Y));

                    DrawLine_Previous_X = (e.X - DrawLine_Starting_X);
                    DrawLine_Previous_Y = (e.Y - DrawLine_Starting_Y);

                }
            }
            else if (overlappingEllipseDraw)
            {
                Overlapping_Ellipse.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\n X: " + e.X.ToString() + " , Y: " + e.Y.ToString() + "\nDO NOT OVERLAP LINES!";


                if (Control.MouseButtons.ToString() == "Left")
                {

                    PaintGraph.DrawEllipse(PaintEraser, DrawLine_Starting_X, DrawLine_Starting_Y, DrawLine_Previous_X, DrawLine_Previous_Y);
                    PaintGraph.DrawEllipse(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, (e.X - DrawLine_Starting_X), (e.Y - DrawLine_Starting_Y));


                    DrawLine_Previous_X = (e.X - DrawLine_Starting_X);
                    DrawLine_Previous_Y = (e.Y - DrawLine_Starting_Y);
                }


            }
            else if (overlappingCircleDraw)
            {
                Overlapping_Circle.Text = "start X: " + DrawLine_Starting_X.ToString() + " , start Y: " + DrawLine_Starting_Y.ToString() +
                                 "\n X: " + e.X.ToString() + " , Y: " + e.Y.ToString() + "\nDO NOT OVERLAP LINES!";


                if (Control.MouseButtons.ToString() == "Left")
                {

                    int diff_X = e.X - DrawLine_Starting_X;
                    int diff_Y = e.Y - DrawLine_Starting_Y;
                    int center = 0;

                    if (diff_X > diff_Y)
                    {
                        center = diff_X;
                    }
                    else if (diff_X < diff_Y)
                    {
                        center = diff_Y;
                    }


                    PaintGraph.DrawEllipse(PaintEraser, DrawLine_Starting_X, DrawLine_Starting_Y, DrawLine_Previous_X, DrawLine_Previous_Y);
                    PaintGraph.DrawEllipse(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, center, center);

                    DrawLine_Previous_X = center;
                    DrawLine_Previous_Y = center;
                }


            }
            else if (eraser)
            {
                Eraser.Text = "X: " + e.X.ToString() + " , Y: " + e.Y.ToString();

                if (Control.MouseButtons.ToString() == "Left")
                {

                    PaintGraph.FillRectangle(myBrush, e.X, e.Y, PaintPen.Width, PaintPen.Width );

                }
            }



        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {

            if (straightLineDraw)
            {

                PaintGraph.DrawLine(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, e.X, e.Y);

            }
            else if (rectangleDraw)
            {

                PaintGraph.DrawRectangle(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, (e.X - DrawLine_Starting_X), (e.Y - DrawLine_Starting_Y) );

            }
            else if (circleDraw)
            {

                int diff_X = e.X - DrawLine_Starting_X;
                int diff_Y = e.Y - DrawLine_Starting_Y;
                int center = 0;

                if (diff_X > diff_Y)
                {
                    center = diff_X;
                }
                else if (diff_X < diff_Y)
                {
                    center = diff_Y;
                }

                PaintGraph.DrawEllipse(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, center, center);

            }
            else if (ellipseDraw)
            { 
                PaintGraph.DrawEllipse(PaintPen, DrawLine_Starting_X, DrawLine_Starting_Y, (e.X - DrawLine_Starting_X), (e.Y - DrawLine_Starting_Y));
            }
            
        }



        private void Draw_Line_Click(object sender, EventArgs e)
        {
            

            if (!straightLineDraw)
            {
                straightLineDraw = true;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                straightLineDraw = false;
                Draw_Line.Text = "Straight Line";

            }


            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";

        }


        private void Abstract_Line_Click(object sender, EventArgs e)
        {
            if (!abstractLineDraw)
            {
                abstractLineDraw = true;
                straightLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                abstractLineDraw = false;
                Abstract_Line.Text = "Abstract Line";

            }

            Draw_Line.Text = "Straight Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";
        }

        private void Overlapping_Line_Click(object sender, EventArgs e)
        {
            

            if (!overlappingLineDraw)
            {
                overlappingLineDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                overlappingLineDraw = false;
                Overlapping_Line.Text = "Overlapping Line";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";

        }

        private void Rectangle_Click(object sender, EventArgs e)
        {

            if (!rectangleDraw)
            {
                rectangleDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                rectangleDraw = false;
                Rectangle.Text = "Rectangle";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";

        }

        private void Circle_Click(object sender, EventArgs e)
        {
            if (!circleDraw)
            {
                circleDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                circleDraw = false;
                Circle.Text = "Circle";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            if (!ellipseDraw)
            {
                ellipseDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                ellipseDraw = false;
                Ellipse.Text = "Ellipse";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";
        }

        private void Overlapping_Rectangle_Click(object sender, EventArgs e)
        {
            if (!overlappingRectangleDraw)
            {
                overlappingRectangleDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                overlappingRectangleDraw = false;
                Overlapping_Rectangle.Text = "Overlapping Rectangle";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";
        }

        private void Overlapping_Circle_Click(object sender, EventArgs e)
        {
            if (!overlappingCircleDraw)
            {
                overlappingCircleDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingEllipseDraw = false;
                eraser = false;
            }
            else
            {
                overlappingEllipseDraw = false;
                Overlapping_Circle.Text = "Overlapping Circle";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";
            Eraser.Text = "Eraser";
        }

        private void Overlapping_Ellipse_Click(object sender, EventArgs e)
        {
            if (!overlappingEllipseDraw)
            {
                overlappingEllipseDraw = true;
                straightLineDraw = false;
                abstractLineDraw = false;
                overlappingLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                eraser = false;
            }
            else
            {
                overlappingEllipseDraw = false;
                Overlapping_Ellipse.Text = "Overlapping Ellipse";

            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Overlapping_Line.Text = "Overlapping Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Eraser.Text = "Eraser";

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            SolidBrush eraseBrush = new SolidBrush(this.BackColor);

            PaintGraph.FillRectangle(eraseBrush, rect);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaintPen.Width = Int32.Parse(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _font = comboBox2.SelectedItem.ToString();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Red;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Green;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Blue;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Yellow;
        }

        private void Fuchsia_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Fuchsia;
        }

        private void Aqua_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Aqua;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Black;
        }

        private void White_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.White;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            PaintPen.Color = Color.Brown;
        }

        private void Eraser_Click(object sender, EventArgs e)
        {

            if (!eraser)
            {
                eraser = true;
                overlappingLineDraw = false;
                straightLineDraw = false;
                abstractLineDraw = false;
                rectangleDraw = false;
                circleDraw = false;
                ellipseDraw = false;
                overlappingRectangleDraw = false;
                overlappingCircleDraw = false;
                overlappingEllipseDraw = false;

                myBrush = new SolidBrush(this.BackColor);


            }
            else
            {
                eraser = false;
                Eraser.Text = "Eraser";
                myBrush.Dispose();


            }

            Draw_Line.Text = "Straight Line";
            Abstract_Line.Text = "Abstract Line";
            Rectangle.Text = "Rectangle";
            Circle.Text = "Circle";
            Ellipse.Text = "Ellipse";
            Overlapping_Rectangle.Text = "Overlapping Rectangle";
            Overlapping_Circle.Text = "Overlapping Circle";
            Overlapping_Ellipse.Text = "Overlapping Ellipse";

            
        }


        


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (index < 16 && index < ticker_draws.Count)
            {
                PaintGraph.DrawLine(PaintPen, ticker_draws[index][0], ticker_draws[index][1], ticker_draws[index][2], ticker_draws[index][3]);
            }
            else if (index > 15 && index < ticker_draws.Count)
            {
                PaintGraph.DrawEllipse(PaintPen, ticker_draws[index][0], ticker_draws[index][1], ticker_draws[index][2], ticker_draws[index][3]);
            }

            index++;

            if (index > ticker_draws.Count)
            {
                timer1.Enabled = false;
                House.Text = "Draw House";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (index < 11 && index < ticker_draws.Count)
            {
                PaintGraph.DrawLine(PaintPen, ticker_draws[index][0], ticker_draws[index][1], ticker_draws[index][2], ticker_draws[index][3]);
            }
            else if (index > 10 && index < ticker_draws.Count)
            {
                PaintGraph.DrawEllipse(PaintPen, ticker_draws[index][0], ticker_draws[index][1], ticker_draws[index][2], ticker_draws[index][3]);
            }

            index++;

            if (index > ticker_draws.Count)
            {
                timer2.Enabled = false;
                Car.Text = "Draw Car";
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (index < ticker_string_draws.Count)
            {
                PaintGraph.DrawString(ticker_string_draws[index], drawFont, stringBrush, _random_X_Y.Next(10, 900), _random_X_Y.Next(10, 600));
            }

            index++;

            if (index > ticker_string_draws.Count)
            {
                timer3.Enabled = false;
                Words.Text = "Draw Words";
            }
        }

        private void House_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;                
                timer3.Enabled = false;
                House.Text = "Drawing...";
                index = 0;
                ticker_draws.Clear();
                house_builder();
            }
            else
            {
                timer1.Enabled = false;
                House.Text = "Draw House";
            }

            
        }

        private void Car_Click(object sender, EventArgs e)
        {
            if (!timer2.Enabled)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                timer3.Enabled = false;
                Car.Text = "Drawing...";
                index = 0;
                ticker_draws.Clear();
                car_builder();
            }
            else
            {
                timer2.Enabled = false;
                Car.Text = "Draw Car";
            }


        }

        private void Words_Click(object sender, EventArgs e)
        {
            stringBrush = new SolidBrush(PaintPen.Color);

            if (_font == null)
            {
                drawFont = new Font("Arial", PaintPen.Width);
            }
            else
            {
                drawFont = new Font(_font, PaintPen.Width);
            }
            

            _random_X_Y = new Random();

            

            if (!timer3.Enabled)
            {
                
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = true;
                Words.Text = "Drawing...";
                index = 0;
                ticker_string_draws.Clear();
                word_builder();
            }
            else
            {
                timer3.Enabled = false;
                Words.Text = "Draw Car";
            }


        }



        private void Clean_All_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            SolidBrush eraseBrush = new SolidBrush(this.BackColor);

            PaintGraph.FillRectangle(eraseBrush, rect);
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(980, 630);
            Graphics save_graphics = Graphics.FromImage(bmp);
            save_graphics.CopyFromScreen(this.Location, Point.Empty, this.Size);


            Rectangle cropped_Rect = new Rectangle(10, 50, 950, 580);
            Bitmap cropped_bmp = new Bitmap(cropped_Rect.Width, cropped_Rect.Height);

            using (Graphics g = Graphics.FromImage(cropped_bmp))
            {
                g.DrawImage(bmp, new Rectangle(0, 0, cropped_bmp.Width, cropped_bmp.Height),
                                 cropped_Rect,
                                 GraphicsUnit.Pixel);
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {

                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        cropped_bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        cropped_bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        cropped_bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
