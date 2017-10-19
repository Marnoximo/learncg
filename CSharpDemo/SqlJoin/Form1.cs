﻿using System;
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
            CbbInit();
            ListViewInit();
            
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

        private void CbbInit()
        {
            string classQuery = "SELECT DISTINCT(Class) FROM sinhvien.dbo.SV2";
            SetDataReader(classQuery);
            cbb_class.Items.Clear();
            while (dataReader.Read())
            {
                cbb_class.Items.Add(dataReader["Class"]);
            }
            FinishReading();
            string FacultyIdQuery = "SELECT DISTINCT(FacultyId) FROM sinhvien.dbo.SV2";
            SetDataReader(FacultyIdQuery);
            cbb_facultyid.Items.Clear();
            while (dataReader.Read())
            {
                cbb_facultyid.Items.Add(dataReader["FacultyId"]);
            }
            FinishReading();
        }

        private void ListViewInit()
        {
            ColumnHeader col_student_id = new ColumnHeader();
            ColumnHeader col_student_name = new ColumnHeader();
            ColumnHeader col_faculty_name = new ColumnHeader();
            
            col_student_id.Text = "ID";
            col_student_id.Width = lv_list.Width/3;
            col_student_name.Text = "Student's Name";
            col_student_name.Width = lv_list.Width/3;
            col_faculty_name.Text = "Faculty's Name";
            col_faculty_name.Width = lv_list.Width/3;
            lv_list.Columns.AddRange(new ColumnHeader[] { col_student_id, col_student_name, col_faculty_name });
        }
        private void ShowRecords()
        {
            string selectAll = "select sv2.ID, sv2.Name, Faculty.FacultyName from sinhvien.dbo.SV2 join sinhvien.dbo.Faculty on sv2.FacultyId = Faculty.FacultyId";
            SetDataReader(selectAll);

            lv_list.Items.Clear();
            while (dataReader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] {dataReader["ID"].ToString(), dataReader["Name"].ToString(), dataReader["FacultyName"].ToString()});
                //item.SubItems[]
                lv_list.Items.Add(item);
            }
            FinishReading();
        }

        private bool IsAvail(string recId)
        {
            string checkRecord = "SELECT COUNT(*) FROM sinhvien.dbo.SV2 WHERE ID= '" + recId + "'";
            if ((int)SqlExecuteScalar(checkRecord) > 0)
                return true;
            return false;
        }

        private void FillWidgetsWithInfo(string recID)
        {
            string recSelect = "SELECT * FROM sinhvien.dbo.sv2 JOIN sinhvien.dbo.Faculty ON sv2.FacultyId = faculty.facultyId WHERE ID = '" + recID + "'";
            SetDataReader(recSelect);
            while (dataReader.Read())
            {
                tb_id.Text = dataReader["ID"].ToString();
                tb_name.Text = dataReader["Name"].ToString();
                cbb_class.SelectedItem = dataReader["Class"].ToString();
                SetGender((bool)dataReader["Gender"]);
                dtp_birthday.Value = (DateTime)dataReader["Birthday"];
                cbb_facultyid.SelectedItem = dataReader["FacultyId"].ToString();
                tb_facultyname.Text = dataReader["FacultyName"].ToString();
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

        private void SetDataGridView()
        {
            sqlCmd.CommandText = "SELECT sv2.id, sv2.name, sv2.class, sv2.birthday, sv2.gender, faculty.facultyname FROM sinhvien.dbo.sv2 JOIN sinhvien.dbo.Faculty ON sv2.FacultyId = faculty.facultyId";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv_student.DataSource = ds.Tables[0];
        }

        //=======================WIDGETS' METHODS======================================//



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
            SetDataGridView();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WidgetsFilled())
            {
                try
                {
                    string id, name, inClass, birthday, gender, facultyId;
                    id = tb_id.Text;
                    name = tb_name.Text;
                    inClass = cbb_class.SelectedItem.ToString();
                    birthday = dtp_birthday.Value.ToShortDateString();
                    gender = rb_male.Checked ? "1" : "0";
                    facultyId = cbb_facultyid.SelectedItem.ToString();

                    if (IsAvail(id))
                    {
                        MessageBox.Show("Already had this id");
                    }
                    else
                    {
                        string addRecord = "INSERT INTO sinhvien.dbo.SV2 VALUES ('" + id + "', '"
                                                                               + name + "', '"
                                                                               + inClass + "', '"
                                                                               + birthday + "', "
                                                                               + gender + ", '"
                                                                               + facultyId + "')";
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

                    string updateRecord = "UPDATE sinhvien.dbo.SV2 SET Name= '" + name
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
                string deleteRecord = "DELETE FROM sinhvien.dbo.SV2 WHERE ID= '" + id + "'";
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

        private void dgv_student_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rowSelected;
            rowSelected = dgv_student.SelectedRows;


            MessageBox.Show("ok");
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