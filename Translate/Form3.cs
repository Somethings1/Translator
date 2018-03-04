using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(206, 236);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.toLang = "vi";
            Form1.toText = "Vietnamese";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.toLang = "en";
            Form1.toText = "English";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.toLang = "ja";
            Form1.toText = "Japanese";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.toLang = "zh";
            Form1.toText = "Chinese";
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.toLang = "fr";
            Form1.toText = "Franch";
            this.Close();
        }
    }
}
