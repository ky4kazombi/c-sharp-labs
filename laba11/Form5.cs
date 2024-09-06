using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            Button btnclose = new Button();
            btnclose.Location = new Point(50, 50);
            btnclose.Name = "btnClose";
            btnclose.Size = new Size(100, 30);
            btnclose.TabIndex = 0;
            btnclose.Text = "Закрыть";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += new EventHandler(btnClose_Click);

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(btnclose);
            this.Name = "SDIForm";
            this.ResumeLayout(false);
            this.Text = "SDI Form";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму при нажатии кнопки
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
