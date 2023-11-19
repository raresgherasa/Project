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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ro.wikipedia.org/wiki/Creier");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
