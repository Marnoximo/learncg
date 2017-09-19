using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi5_windowFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(t_mssv.Text);
        }

        private void cb_khoa_index_changed(object sender, EventArgs e)
        {
            MessageBox.Show(t_khoa.Items[t_khoa.SelectedIndex].ToString());
        }

        private void
        
    }
}
