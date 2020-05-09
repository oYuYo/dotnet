/// <summary>
/// This Program splits string at '\n'
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "aiueo" + '\r' + '\n' + "11111" + "\r\n" + "22222" + "\r\n" + "33333";
            Label[] lbl = new Label[] { split_text1, split_text2, split_text3, split_text4 };
            string[] wordList = textBox1.Text.Replace("\r\n", "\n").Split('\n');
            for (int i=0; i<wordList.Length; i++)
            {
                lbl[i].Text = wordList[i];
            }
        }
    }
}
