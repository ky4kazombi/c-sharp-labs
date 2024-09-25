using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            pictureBox1.Paint += PictureBox_Paint;
            this.Controls.Add(pictureBox1);
        }
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуем фигуры

            // Круг
            g.FillEllipse(Brushes.Red, 50, 50, 100, 100);

            // Прямоугольник
            g.FillRectangle(Brushes.Green, 200, 50, 150, 100);

            // Треугольник
            Point[] trianglePoints = {
                new Point(400, 150),
                new Point(350, 50),
                new Point(450, 50)
            };
            g.FillPolygon(Brushes.Blue, trianglePoints);

            // Овал
            g.FillEllipse(Brushes.Yellow, 50, 200, 150, 100);

            // Прямоугольник с закругленными углами
            GraphicsPath roundedRect = new GraphicsPath();
            int radius = 20; // радиус закругления
            roundedRect.AddArc(200, 200, radius, radius, 180, 90);
            roundedRect.AddArc(350 - radius, 200, radius, radius, 270, 90);
            roundedRect.AddArc(350 - radius, 300 - radius, radius, radius, 0, 90);
            roundedRect.AddArc(200, 300 - radius, radius, radius, 90, 90);
            roundedRect.CloseFigure();
            g.FillPath(Brushes.Purple, roundedRect);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
