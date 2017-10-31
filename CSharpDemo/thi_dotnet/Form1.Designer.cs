namespace thi_dotnet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_pname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_manu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pid = new System.Windows.Forms.TextBox();
            this.tb_pname = new System.Windows.Forms.TextBox();
            this.dtp_import = new System.Windows.Forms.DateTimePicker();
            this.cbb_brand = new System.Windows.Forms.ComboBox();
            this.cbb_manu = new System.Windows.Forms.ComboBox();
            this.rb_con = new System.Windows.Forms.RadioButton();
            this.rb_het = new System.Windows.Forms.RadioButton();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cbb_search_field = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_het);
            this.groupBox1.Controls.Add(this.rb_con);
            this.groupBox1.Controls.Add(this.cbb_manu);
            this.groupBox1.Controls.Add(this.cbb_brand);
            this.groupBox1.Controls.Add(this.dtp_import);
            this.groupBox1.Controls.Add(this.tb_pname);
            this.groupBox1.Controls.Add(this.tb_pid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_manu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_pname);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(26, 35);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 17);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Ma SP";
            // 
            // lb_pname
            // 
            this.lb_pname.AutoSize = true;
            this.lb_pname.Location = new System.Drawing.Point(26, 69);
            this.lb_pname.Name = "lb_pname";
            this.lb_pname.Size = new System.Drawing.Size(55, 17);
            this.lb_pname.TabIndex = 1;
            this.lb_pname.Text = "Ten SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngay nhap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mat Hang";
            // 
            // lb_manu
            // 
            this.lb_manu.AutoSize = true;
            this.lb_manu.Location = new System.Drawing.Point(423, 68);
            this.lb_manu.Name = "lb_manu";
            this.lb_manu.Size = new System.Drawing.Size(56, 17);
            this.lb_manu.TabIndex = 4;
            this.lb_manu.Text = "Nha SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tinh trang";
            // 
            // tb_pid
            // 
            this.tb_pid.Location = new System.Drawing.Point(89, 29);
            this.tb_pid.Name = "tb_pid";
            this.tb_pid.ReadOnly = true;
            this.tb_pid.Size = new System.Drawing.Size(100, 22);
            this.tb_pid.TabIndex = 6;
            // 
            // tb_pname
            // 
            this.tb_pname.Location = new System.Drawing.Point(89, 63);
            this.tb_pname.Name = "tb_pname";
            this.tb_pname.Size = new System.Drawing.Size(100, 22);
            this.tb_pname.TabIndex = 7;
            // 
            // dtp_import
            // 
            this.dtp_import.Location = new System.Drawing.Point(109, 95);
            this.dtp_import.Name = "dtp_import";
            this.dtp_import.Size = new System.Drawing.Size(200, 22);
            this.dtp_import.TabIndex = 8;
            // 
            // cbb_brand
            // 
            this.cbb_brand.FormattingEnabled = true;
            this.cbb_brand.Location = new System.Drawing.Point(526, 26);
            this.cbb_brand.Name = "cbb_brand";
            this.cbb_brand.Size = new System.Drawing.Size(121, 24);
            this.cbb_brand.TabIndex = 9;
            // 
            // cbb_manu
            // 
            this.cbb_manu.FormattingEnabled = true;
            this.cbb_manu.Location = new System.Drawing.Point(526, 59);
            this.cbb_manu.Name = "cbb_manu";
            this.cbb_manu.Size = new System.Drawing.Size(121, 24);
            this.cbb_manu.TabIndex = 10;
            // 
            // rb_con
            // 
            this.rb_con.AutoSize = true;
            this.rb_con.Location = new System.Drawing.Point(526, 95);
            this.rb_con.Name = "rb_con";
            this.rb_con.Size = new System.Drawing.Size(54, 21);
            this.rb_con.TabIndex = 11;
            this.rb_con.TabStop = true;
            this.rb_con.Text = "Con";
            this.rb_con.UseVisualStyleBackColor = true;
            this.rb_con.CheckedChanged += new System.EventHandler(this.StatusClick);
            // 
            // rb_het
            // 
            this.rb_het.AutoSize = true;
            this.rb_het.Location = new System.Drawing.Point(675, 94);
            this.rb_het.Name = "rb_het";
            this.rb_het.Size = new System.Drawing.Size(51, 21);
            this.rb_het.TabIndex = 12;
            this.rb_het.TabStop = true;
            this.rb_het.Text = "Het";
            this.rb_het.UseVisualStyleBackColor = true;
            this.rb_het.CheckedChanged += new System.EventHandler(this.StatusClick);
            // 
            // dgv_product
            // 
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(30, 218);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.Size = new System.Drawing.Size(877, 251);
            this.dgv_product.TabIndex = 1;
            this.dgv_product.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(366, 518);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(466, 518);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(566, 518);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(249, 22);
            this.tb_search.TabIndex = 4;
            // 
            // cbb_search_field
            // 
            this.cbb_search_field.FormattingEnabled = true;
            this.cbb_search_field.Location = new System.Drawing.Point(868, 515);
            this.cbb_search_field.Name = "cbb_search_field";
            this.cbb_search_field.Size = new System.Drawing.Size(121, 24);
            this.cbb_search_field.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 577);
            this.Controls.Add(this.cbb_search_field);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_het;
        private System.Windows.Forms.RadioButton rb_con;
        private System.Windows.Forms.ComboBox cbb_manu;
        private System.Windows.Forms.ComboBox cbb_brand;
        private System.Windows.Forms.DateTimePicker dtp_import;
        private System.Windows.Forms.TextBox tb_pname;
        private System.Windows.Forms.TextBox tb_pid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_manu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_pname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cbb_search_field;
    }
}

