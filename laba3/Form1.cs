using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ввод данных
                int N = int.Parse(Nbox.Text);
                int[] array = ArrayBox.Text.Split(',')
                                                .Select(int.Parse)
                                                .ToArray();
                string[] kAndL = KLbox.Text.Split(',');
                int K = int.Parse(kAndL[0]);
                int L = int.Parse(kAndL[1]);

                // Проверка корректности ввода
                if (array.Length != N || K < 1 || L > N || K > L)
                {
                    MessageBox.Show("Проверьте входные данные!");
                    return;
                }

                // Вычисление суммы
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + 1 < K || i + 1 > L) // +1 для учета индексации с 1
                    {
                        sum += array[i];
                    }
                }

                // Вывод результата
                ResultBox.Text = $"Результат: {sum}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
