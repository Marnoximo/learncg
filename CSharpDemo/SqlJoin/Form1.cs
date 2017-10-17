using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlJoin
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlCnt;
        private SqlCommand sqlCmd;
        private SqlDataReader dataReader;
        private string cntString;
        public Form1()
        {
            InitializeComponent();

            SqlInit();
            ClassCbbInit();

        }

        private void SqlInit()
        {
            sqlCnt = new SqlConnection();
            cntString = @"Data Source=DESKTOP-2MI7EK9\TIENSQLSERVER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlCnt.ConnectionString = cntString;

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCnt;
        }

        private void SetDataReader(string query)
        {
            sqlCmd.CommandText = query;
            sqlCnt.Open();
            dataReader = sqlCmd.ExecuteReader();
        }

        private void FinishReading()
        {
            dataReader.Close();
            sqlCnt.Close();
        }
        private int SqlExecuteNonQuery(string query)
        {
            sqlCmd.CommandText = query;
            sqlCnt.Open();
            int count = sqlCmd.ExecuteNonQuery();
            sqlCnt.Close();
            return count;
        }

        private object SqlExecuteScalar(string query)
        {
            sqlCmd.CommandText = query;
            sqlCnt.Open();
            object obj = sqlCmd.ExecuteScalar();
            sqlCnt.Close();
            return obj;
        }

        private void ClassCbbInit()
        {
            string classQuery = "SELECT DISTINCT(Class) FROM sinhvien.dbo.SV";
            SetDataReader(classQuery);
            cbb_class.Items.Clear();
            while (dataReader.Read())
            {
                cbb_class.Items.Add(dataReader["Class"]);
            }
            FinishReading();
        }

        private void ShowRecords()
        {
            string selectAll = "SELECT * FROM sinhvien.dbo.SV";
            SetDataReader(selectAll);

            lv_list.Items.Clear();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { dataReader["ID"].ToString(),
                                                                    dataReader["Name"].ToString(),
                                                                    dataReader["Class"].ToString(),
                                                                    ((DateTime) dataReader["Birthday"]).ToShortDateString(),
                                                                    dataReader["Gender"].ToString() });
                lv_list.Items.Add(item);
            }
            FinishReading();
        }

        private bool IsAvail(string recId)
        {
            string checkRecord = "SELECT COUNT(*) FROM sinhvien.dbo.SV WHERE ID= '" + recId + "'";
            if ((int)SqlExecuteScalar(checkRecord) > 0)
                return true;
            return false;
        }

        private void FillWidgetsWithInfo(string recID)
        {
            string recSelect = "SELECT * FROM sinhvien.dbo.sv WHERE ID = '" + recID + "'";
            SetDataReader(recSelect);
            while (dataReader.Read())
            {
                tb_id.Text = dataReader["ID"].ToString();
                tb_name.Text = dataReader["Name"].ToString();
                cbb_class.SelectedItem = dataReader["Class"].ToString();
                SetGender((bool)dataReader["Gender"]);
                dtp_birthday.Value = (DateTime)dataReader["Birthday"];
            }
            FinishReading();
        }

        private void SetGender(bool isMale)
        {
            if (isMale)
            {
                rb_male.Checked = true;
                rb_female.Checked = false;
            }
            else
            {
                rb_male.Checked = false;
                rb_female.Checked = true;
            }
        }

        private bool WidgetsFilled()
        {
            if (tb_name.Text != "" && tb_id.Text != "" && cbb_class.SelectedItem != null && (rb_male.Checked || rb_female.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GenderClick(object sender, EventArgs e)
        {
            if (rb_male.Checked)
                rb_female.Checked = false;
            else
                rb_female.Checked = true;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowRecords();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WidgetsFilled())
            {
                try
                {
                    string id, name, inClass, birthday, gender;
                    id = tb_id.Text;
                    name = tb_name.Text;
                    inClass = cbb_class.SelectedItem.ToString();
                    birthday = dtp_birthday.Value.ToShortDateString();
                    gender = rb_male.Checked ? "1" : "0";

                    if (IsAvail(id))
                    {
                        MessageBox.Show("Already had this id");
                    }
                    else
                    {
                        string addRecord = "INSERT INTO sinhvien.dbo.SV VALUES ('" + id + "', '"
                                                                               + name + "', '"
                                                                               + inClass + "', '"
                                                                               + birthday + "', "
                                                                               + gender + ")";
                        SqlExecuteNonQuery(addRecord);
                        ShowRecords();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all needed information");
            }
        }

        private void lv_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection slItems;
            slItems = lv_list.SelectedItems;
            if (slItems.Count > 0)
            {
                string selected_id = slItems[0].SubItems[0].Text;
                FillWidgetsWithInfo(selected_id);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (WidgetsFilled())
            {
                try
                {
                    string id, name, inClass, birthday, gender;
                    id = tb_id.Text;
                    name = tb_name.Text;
                    inClass = cbb_class.SelectedItem.ToString();
                    birthday = dtp_birthday.Value.ToShortDateString();
                    gender = rb_male.Checked ? "1" : "0";

                    string updateRecord = "UPDATE sinhvien.dbo.SV SET Name= '" + name
                                            + "', Class= '" + inClass
                                            + "', Birthday= '" + birthday
                                            + "', Gender= " + gender
                                            + " WHERE ID= '" + id + "'";
                    SqlExecuteNonQuery(updateRecord);
                    ShowRecords();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all needed information");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tb_id.Text;
                string deleteRecord = "DELETE FROM sinhvien.dbo.SV WHERE ID= '" + id + "'";
                SqlExecuteNonQuery(deleteRecord);
                ShowRecords();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String id = tb_search.Text;
            FillWidgetsWithInfo(id);
        }
        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }*/
    }
}
