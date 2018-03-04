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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 Form1 = new Form1();

        private void Form2_Resize(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(206, 236);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.fromLang = "vi";
            Form1.frText = "Vietnamese";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.fromLang = "en";
            Form1.frText = "English";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.fromLang = "ja";
            Form1.frText = "Japanese";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.fromLang = "zh";
            Form1.frText = "Chinese";
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.fromLang = "fr";
            Form1.frText = "Franch";
            this.Close();
        }
    }
}
