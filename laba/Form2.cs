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
    public partial class Form2 : Form
    {
        private Timer timer;
        private float progress = 0;
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50; // интервал в миллисекундах
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Увеличиваем прогресс для анимации
            progress += 0.05f;
            if (progress > 1)
            {
                progress = 0; // сброс прогресса
            }
            this.Invalidate(); // Перерисовка формы
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGraph(e.Graphics);
        }
        private void DrawGraph(Graphics g)
        {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            // Масштабируем график
            g.TranslateTransform(width / 2, height / 2);
            g.ScaleTransform(1, -1); // Инвертируем по вертикали

            // Рисуем гиперболу
            float a = 50; // Параметры гиперболы
            float b = 30;

            // Рисуем линии гиперболы
            g.DrawArc(Pens.Blue, -a * 2, -b, a * 2, b * 2, 0, 180);
            g.DrawArc(Pens.Blue, -a * 2, -b * 2, a * 2, b * 2, 180, 180);

            // Определяем изменение для анимации
            float shift = progress * 300 - 150;

            // Применяем смещение
            g.DrawArc(Pens.Red, -a * 2 + shift, -b, a * 2, b * 2, 0, 180);
            g.DrawArc(Pens.Red, -a * 2 + shift, -b * 2, a * 2, b * 2, 180, 180);
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start(); // Запускаем анимацию
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
