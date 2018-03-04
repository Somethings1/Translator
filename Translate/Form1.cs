using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DarrenLee.Translator;

namespace Translate
{
    public partial class Form1 : Form
    {
        public static string fromLang = "en", toLang = "vi", frText = "English", toText = "Vietnamese";

        public Form1()
        {
            InitializeComponent();
            this.fromLgg.Text = frText;
            this.toLgg.Text = toText;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(705, 350);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, 
                "Click the text of language to change the input \nand the result languages.", 
                "How to use",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text;
            if (s != "")
            {
                try
                {
                    Translator.Translate(s, fromLang, toLang);
                    this.textBox2.Text = Translator.Translate(s, fromLang, toLang);
                }
                catch
                {
                    MessageBox.Show(this, 
                        "Something went wrong! Please try again\nMake sure internet is contected", 
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                this.textBox2.Text = "";
            }
        }

        private void fromLgg_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            this.fromLgg.Text = frText;
            this.toLgg.Text = toText;
        }

        private void toLgg_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            frm.Show();
        }
    }
}
