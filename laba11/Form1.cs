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

namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Установите размеры формы
            this.Size = new Size(300, 200);
            this.FormBorderStyle = FormBorderStyle.None; // Убираем стандартную рамку
            this.StartPosition = FormStartPosition.CenterScreen; // Ставим форму по центру экрана

            // Добавляем кнопку для закрытия формы
            Button closeButton = new Button();
            closeButton.Text = "Закрыть";
            closeButton.Location = new Point(this.Width / 2 - 30, this.Height / 2 - 15);
            closeButton.Click += (sender, e) => this.Close();

            this.Controls.Add(closeButton);
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Создаем путь для отрисовки овала
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(myPath); // Задаем форму области
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
