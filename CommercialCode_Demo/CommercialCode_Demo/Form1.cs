using CommercialCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommercialCode_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MorseCode mycode = new MorseCode();
        ChineseCommercialCode mycncode = new ChineseCommercialCode();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = mycode.TextToCode(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = mycode.CodeToText(textBox4.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Text = mycode.point;
            textBox6.Text = mycode.line;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            mycode.point = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            mycode.line = textBox6.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = mycncode.TextToCode(textBox8.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = mycncode.CodeToText(textBox10.Text);
        }
    }
}
