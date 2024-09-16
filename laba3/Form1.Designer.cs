namespace laba3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ArrayBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.KLbox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nbox
            // 
            this.Nbox.Location = new System.Drawing.Point(288, 50);
            this.Nbox.Name = "Nbox";
            this.Nbox.Size = new System.Drawing.Size(88, 20);
            this.Nbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите длинну массива n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите массив через запятую";
            // 
            // ArrayBox
            // 
            this.ArrayBox.Location = new System.Drawing.Point(288, 95);
            this.ArrayBox.Name = "ArrayBox";
            this.ArrayBox.Size = new System.Drawing.Size(161, 20);
            this.ArrayBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите K L через запятую";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // KLbox
            // 
            this.KLbox.Location = new System.Drawing.Point(288, 142);
            this.KLbox.Name = "KLbox";
            this.KLbox.Size = new System.Drawing.Size(161, 20);
            this.KLbox.TabIndex = 4;
            this.KLbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(118, 197);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(331, 23);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Рассчитать сумму";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(118, 262);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(331, 20);
            this.ResultBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(528, 412);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KLbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArrayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nbox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ArrayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KLbox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox ResultBox;
    }
}

