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
    public partial class Form3 : Form
    {
        public Form3() 
        {
            InitializeComponent();
            this.Text = "Гайнутдинов Артём Эдуардович, группа ВКБ33";
            this.WindowState = FormWindowState.Maximized; 

            Button buttonOpenForm1 = new Button();
            buttonOpenForm1.Text = "Открыть первую форму";
            buttonOpenForm1.Click += new EventHandler(buttonOpenForm1_Click);
            buttonOpenForm1.Dock = DockStyle.Top;

            this.Controls.Add(buttonOpenForm1);
        }

        private void buttonOpenForm1_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.ShowDialog(); 
        }
    

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
