using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi7_delegatePractice
{
    public delegate void TextChange(string s);
    public partial class Form2 : Form
    {
        public TextChange t;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (t != null)
                t(textBox1.Text);
        }
    }
}
