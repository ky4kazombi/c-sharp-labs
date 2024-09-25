using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawHyperbola();
        }
        private void DrawHyperbola()
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);

            // Очищаем фон
            g.Clear(Color.White);

            // Рисуем оси координат
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, width / 2, 0, width / 2, height);
            g.DrawLine(axisPen, 0, height / 2, width, height / 2);

            // Рисуем гиперболу
            Pen hyperbolaPen = new Pen(Color.Red, 2);
            for (float x = -10; x <= 10; x += 0.01f)
            {
                if (x == 0) continue; // Избегаем деления на ноль

                float y = 1 / x;
                // Преобразуем координаты из математических в пиксельные
                int pixelX = (int)(width / 2 + x * 20); // Умножаем на масштаб
                int pixelY = (int)(height / 2 - y * 20); // Обратите внимание на минус для вертикальной оси

                g.FillRectangle(hyperbolaPen.Brush, pixelX, pixelY, 1, 1);
            }

            // Выводим изображение в PictureBox
            pictureBox1.Image = bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.ShowDialog();
        }
    }
}
