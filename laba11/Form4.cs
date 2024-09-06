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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            Button btnOpenSDI = new Button();
            btnOpenSDI.SuspendLayout();
            btnOpenSDI.Location = new Point(20, 20);
            btnOpenSDI.Size = new System.Drawing.Size(150, 30);
            btnOpenSDI.TabIndex = 0;
            btnOpenSDI.Text = "Открыть SDI форму";
            btnOpenSDI.UseVisualStyleBackColor = true;
            btnOpenSDI.Click += new EventHandler(btnOpenSDI_Click);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnOpenSDI);
            this.Name = "Main MDI Form";
            this.Text = "MDI form"; 
            this.ResumeLayout(false);

        }
        private void btnOpenSDI_Click(object sender, EventArgs e)
        {
            var sdiForm = new Form5();
            sdiForm.MdiParent = this; // Установим родительскую форму
            sdiForm.Show(); // Покажем SDI форму
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
