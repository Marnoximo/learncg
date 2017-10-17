using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventAndDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void HandleClick(object sender, EventArgs e)
        {
            MessageBox.Show("aslkdjalsdjlaskj");
        }

    }
}
