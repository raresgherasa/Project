using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, label1.Width, label1.Height);
            this.label1.Region = new Region(path);
            label1.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 brain = new Form2();
            brain.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 stomac = new Form4();
            stomac.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form5 testicul = new Form5();
            testicul.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 quiz = new Form3();
            quiz.Visible = true;
        }
    }
}
