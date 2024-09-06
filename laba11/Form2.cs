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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; 
            this.Size = new Size(200, 200);
            this.BackColor = Color.Green;
            
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(new Point[]
            {
                new Point(100, 0),
                new Point(200, 100),
                new Point(100, 200),
                new Point(0, 100)
            });
            this.Region = new Region(path);

            Button btnClose = new Button();
            btnClose.Text = "GREENPEACE";
            btnClose.Click += new EventHandler(btnClose_Click);
            btnClose.Dock = DockStyle.Fill; 

            this.Controls.Add(btnClose);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

