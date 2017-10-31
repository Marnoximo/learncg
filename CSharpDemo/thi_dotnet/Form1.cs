using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thi_dotnet
{
    public partial class Form1 : Form
    {
        public Helper helper { get; set; }
        private string cntString = @"Data Source=DESKTOP-2MI7EK9\TIENSQLSERVER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string selectAll = "select thi_sp.product_id, thi_sp.product_name, thi_sp.import_date, thi_sp.manufacturer, thi_sp.status, thi_mh.brand_name from sinhvien.dbo.thi_sp join sinhvien.dbo.thi_mh on thi_sp.brand_id = thi_mh.brand_id";
        public Form1()
        {
            InitializeComponent();
            DataHelperInit();
            CbbInit();
        }

        //==================INIT===========================//
        //=================================================//
        private void DataHelperInit()
        {
            helper = new Helper(cntString);
        }

        private void CbbInit()
        {
            string manuQuery = "SELECT DISTINCT(manufacturer) FROM sinhvien.dbo.thi_sp";
            DataTable dt = helper.ExecuteDataSet(manuQuery);
            
            cbb_manu.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb_manu.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }
            string brandIdQuery = "SELECT DISTINCT(brand_name) FROM sinhvien.dbo.thi_mh";
            dt = helper.ExecuteDataSet(brandIdQuery);

            cbb_brand.Items.Clear();
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cbb_brand.Items.Add(dt.Rows[i].ItemArray[0].ToString());
            }

            cbb_search_field.Items.AddRange(new string[]{ "ID", "Name", "Imp_date", "Manufacturer", "Brand ID"});
        }

        //===================AUX FUNC=========================//
        //====================================================//

        private void ShowRecords(string query)
        {
            DataTable dt = helper.ExecuteDataSet(query);
            if(dgv_product.ColumnCount == 0)
            dgv_product.Columns.Add("STT","STT");
            dgv_product.DataSource = dt;
            int num = dt.Rows.Count;
            for(int i = 0; i < num; i++)
            {
                dgv_product.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private bool IsAvail(string recId)
        {
            string checkRecord = "SELECT COUNT(*) FROM sinhvien.dbo.thi_sp WHERE product_id= '" + recId + "'";
            if (helper.ExecuteScalar(checkRecord) > 0)
                return true;
            return false;
        }

        private void SetStatus(bool isTrue)
        {
            if (isTrue)
            {
                rb_con.Checked = true;
                rb_het.Checked = false;
            }
            else
            {
                rb_con.Checked = false;
                rb_het.Checked = true;
            }
        }

        private void FillWidgetsWithInfo(string recID)
        {
            string recSelect = "SELECT * FROM sinhvien.dbo.thi_sp JOIN sinhvien.dbo.thi_mh ON thi_sp.brand_id = thi_mh.brand_id WHERE product_id = '" + recID + "'";
            
            DataTable dt = helper.ExecuteDataSet(recSelect);
            DataRow row = dt.Rows[0];
                tb_pid.Text = row["product_id"].ToString();
                tb_pname.Text = row["product_name"].ToString();
                cbb_manu.SelectedItem = row["manufacturer"].ToString();
                SetStatus((bool) row["status"]);
                dtp_import.Value = (DateTime)row["import_date"];
                cbb_brand.SelectedItem = row["brand_name"].ToString();
        }

        private bool WidgetsFilled()
        {
            if (tb_pname.Text != "" && cbb_manu.SelectedItem != null && cbb_brand.SelectedItem != null && (rb_con.Checked || rb_het.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetBrandID(string bname)
        {
            string bid;
            string query = "select brand_id from sinhvien.dbo.thi_mh where brand_name = '" + bname + "'";
            bid = helper.ExecuteDataSet(query).Rows[0].ItemArray[0].ToString();
            return bid;
        }

        private string GeneratePID()
        {
            int start = 100;
            while(IsAvail(start.ToString()) == true)
            {
                start++;
            }
            return start.ToString();
        }

        //=======================WIDGETS' METHODS======================================//

        private void StatusClick(object sender, EventArgs e)
        {
            if (rb_con.Checked)
                rb_het.Checked = false;
            else
                rb_het.Checked = true;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            ShowRecords(selectAll);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (WidgetsFilled())
            {
                try
                {
                    string pid, pname, manu, imp_date, status, brand_name;
                    pid = GeneratePID();
                    pname = tb_pname.Text;
                    manu = cbb_manu.SelectedItem.ToString();
                    imp_date = dtp_import.Value.ToShortDateString();
                    status = rb_con.Checked ? "1" : "0";
                    brand_name = GetBrandID(cbb_brand.SelectedItem.ToString());

                    if (IsAvail(pid))
                    {
                        MessageBox.Show("Already had this id");
                    }
                    else
                    {
                        string addRecord = "INSERT INTO sinhvien.dbo.thi_sp VALUES ('" + pid + "', '"
                                                                               + pname + "', '"
                                                                               + imp_date + "', '"
                                                                               + manu + "', "
                                                                               + status + ", '"
                                                                               + brand_name + "')";
                        helper.ExecuteNonQuery(addRecord);
                        ShowRecords(selectAll);
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (true)
            {
                try
                {
                    string pid, pname, manu, imp_date, status, brand_name;
                    pid = tb_pid.Text;
                    pname = tb_pname.Text;
                    manu = cbb_manu.SelectedItem.ToString();
                    imp_date = dtp_import.Value.ToShortDateString();
                    status = rb_con.Checked ? "1" : "0";
                    brand_name = GetBrandID(cbb_brand.SelectedItem.ToString());

                    string updateRecord = "UPDATE sinhvien.dbo.thi_sp SET product_name= '" + pname
                                            + "', manufacturer = '" + manu
                                            + "', import_date = '" + imp_date
                                            + "', status = " + status
                                            + ", brand_id = '" + brand_name
                                            + "' WHERE product_id = '" + pid + "'";
                    helper.ExecuteNonQuery(updateRecord);
                    ShowRecords(selectAll);
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
                string pid = tb_pid.Text;
                string deleteRecord = "DELETE FROM sinhvien.dbo.thi_sp WHERE product_id = '" + pid + "'";
                helper.ExecuteNonQuery(deleteRecord);
                ShowRecords(selectAll);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string value = tb_search.Text, field_search = "";
            int field_index = cbb_search_field.SelectedIndex;
            switch(field_index)
            {
                case 0:
                    {
                        field_search = "product_id";
                        break;
                    }
                case 1:
                    {
                        field_search = "product_name";
                        break;
                    }
                case 2:
                    {
                        field_search = "import_date";
                        break;
                    }
                case 3:
                    {
                        field_search = "manufacturer";
                        break;
                    }
                case 4:
                    {
                        string brand_id = GetBrandID(tb_search.Text);
                        field_search = "brand_id";
                        string queryBrand = "select * from sinhvien.dbo.thi_sp where " + field_search + " = '" + value + "'";
                        ShowRecords(queryBrand);
                        break;
                    }
                default:
                    return;
            }
            string query = "select * from sinhvien.dbo.thi_sp where " + field_search + " = '" + value + "'";
            ShowRecords(query);
        }

        private void dgv_product_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection rowSelected;
            rowSelected = dgv_product.SelectedRows;
            if (rowSelected.Count > 0)
            {
                FillWidgetsWithInfo(rowSelected[0].Cells[1].Value.ToString());
            }
        }
    }
}
