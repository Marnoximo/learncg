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

        private void lv_sinhvien_index_changed(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection l;
            l = listView1.SelectedItems;
            if (l.Count >0)
            {
                MessageBox.Show(l[0].SubItems[1].ToString()); 
            }
        }

        private void rb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nam.Checked)
                rb_nu.Checked = false;

        }

        private void rb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nu.Checked)
                rb_nam.Checked = false;
        }

        private void rb_gender_checkedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //Sinhvien sv = new Sinhvien(1, "Tien", "cntt");
            //listView1.Items.Add(new ListViewItem(new String[] = { sv}));
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
