﻿namespace Buoi5_windowFormDemo
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
            this.gb_sinhVien = new System.Windows.Forms.GroupBox();
            this.l_khoa = new System.Windows.Forms.Label();
            this.t_khoa = new System.Windows.Forms.ComboBox();
            this.gb_nnlt = new System.Windows.Forms.GroupBox();
            this.cb_aspnetmvc = new System.Windows.Forms.CheckBox();
            this.cb_vb = new System.Windows.Forms.CheckBox();
            this.cb_csharp = new System.Windows.Forms.CheckBox();
            this.gb_gioiTinh = new System.Windows.Forms.GroupBox();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.l_ngaySinh = new System.Windows.Forms.Label();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.t_hoTen = new System.Windows.Forms.TextBox();
            this.l_hoTen = new System.Windows.Forms.Label();
            this.l_mssv = new System.Windows.Forms.Label();
            this.t_mssv = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.t_searchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_sinhVien.SuspendLayout();
            this.gb_nnlt.SuspendLayout();
            this.gb_gioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_sinhVien
            // 
            this.gb_sinhVien.Controls.Add(this.button1);
            this.gb_sinhVien.Controls.Add(this.l_khoa);
            this.gb_sinhVien.Controls.Add(this.t_khoa);
            this.gb_sinhVien.Controls.Add(this.gb_nnlt);
            this.gb_sinhVien.Controls.Add(this.gb_gioiTinh);
            this.gb_sinhVien.Controls.Add(this.l_ngaySinh);
            this.gb_sinhVien.Controls.Add(this.dtp_ngaySinh);
            this.gb_sinhVien.Controls.Add(this.t_hoTen);
            this.gb_sinhVien.Controls.Add(this.l_hoTen);
            this.gb_sinhVien.Controls.Add(this.l_mssv);
            this.gb_sinhVien.Controls.Add(this.t_mssv);
            this.gb_sinhVien.Location = new System.Drawing.Point(43, 41);
            this.gb_sinhVien.Name = "gb_sinhVien";
            this.gb_sinhVien.Size = new System.Drawing.Size(834, 223);
            this.gb_sinhVien.TabIndex = 0;
            this.gb_sinhVien.TabStop = false;
            this.gb_sinhVien.Text = "Sinh vien";
            // 
            // l_khoa
            // 
            this.l_khoa.AutoSize = true;
            this.l_khoa.Location = new System.Drawing.Point(19, 140);
            this.l_khoa.Name = "l_khoa";
            this.l_khoa.Size = new System.Drawing.Size(41, 17);
            this.l_khoa.TabIndex = 11;
            this.l_khoa.Text = "Khoa";
            // 
            // t_khoa
            // 
            this.t_khoa.FormattingEnabled = true;
            this.t_khoa.Items.AddRange(new object[] {
            "13T1",
            "13T2",
            "13T3"});
            this.t_khoa.Location = new System.Drawing.Point(76, 137);
            this.t_khoa.Name = "t_khoa";
            this.t_khoa.Size = new System.Drawing.Size(121, 24);
            this.t_khoa.TabIndex = 10;
            // 
            // gb_nnlt
            // 
            this.gb_nnlt.Controls.Add(this.cb_aspnetmvc);
            this.gb_nnlt.Controls.Add(this.cb_vb);
            this.gb_nnlt.Controls.Add(this.cb_csharp);
            this.gb_nnlt.Location = new System.Drawing.Point(565, 31);
            this.gb_nnlt.Name = "gb_nnlt";
            this.gb_nnlt.Size = new System.Drawing.Size(200, 100);
            this.gb_nnlt.TabIndex = 9;
            this.gb_nnlt.TabStop = false;
            this.gb_nnlt.Text = "NNLT";
            // 
            // cb_aspnetmvc
            // 
            this.cb_aspnetmvc.AutoSize = true;
            this.cb_aspnetmvc.Location = new System.Drawing.Point(25, 73);
            this.cb_aspnetmvc.Name = "cb_aspnetmvc";
            this.cb_aspnetmvc.Size = new System.Drawing.Size(122, 21);
            this.cb_aspnetmvc.TabIndex = 2;
            this.cb_aspnetmvc.Text = "ASP.NET MVC";
            this.cb_aspnetmvc.UseVisualStyleBackColor = true;
            // 
            // cb_vb
            // 
            this.cb_vb.AutoSize = true;
            this.cb_vb.Location = new System.Drawing.Point(25, 50);
            this.cb_vb.Name = "cb_vb";
            this.cb_vb.Size = new System.Drawing.Size(48, 21);
            this.cb_vb.TabIndex = 1;
            this.cb_vb.Text = "VB";
            this.cb_vb.UseVisualStyleBackColor = true;
            // 
            // cb_csharp
            // 
            this.cb_csharp.AutoSize = true;
            this.cb_csharp.Location = new System.Drawing.Point(25, 22);
            this.cb_csharp.Name = "cb_csharp";
            this.cb_csharp.Size = new System.Drawing.Size(47, 21);
            this.cb_csharp.TabIndex = 0;
            this.cb_csharp.Text = "C#";
            this.cb_csharp.UseVisualStyleBackColor = true;
            // 
            // gb_gioiTinh
            // 
            this.gb_gioiTinh.Controls.Add(this.rb_nu);
            this.gb_gioiTinh.Controls.Add(this.rb_nam);
            this.gb_gioiTinh.Location = new System.Drawing.Point(260, 71);
            this.gb_gioiTinh.Name = "gb_gioiTinh";
            this.gb_gioiTinh.Size = new System.Drawing.Size(200, 100);
            this.gb_gioiTinh.TabIndex = 8;
            this.gb_gioiTinh.TabStop = false;
            this.gb_gioiTinh.Text = "Gioi tinh";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(39, 50);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(47, 21);
            this.rb_nu.TabIndex = 1;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nu";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(39, 22);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(58, 21);
            this.rb_nam.TabIndex = 0;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // l_ngaySinh
            // 
            this.l_ngaySinh.AutoSize = true;
            this.l_ngaySinh.Location = new System.Drawing.Point(257, 35);
            this.l_ngaySinh.Name = "l_ngaySinh";
            this.l_ngaySinh.Size = new System.Drawing.Size(71, 17);
            this.l_ngaySinh.TabIndex = 7;
            this.l_ngaySinh.Text = "Ngay sinh";
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Location = new System.Drawing.Point(334, 31);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(181, 22);
            this.dtp_ngaySinh.TabIndex = 6;
            // 
            // t_hoTen
            // 
            this.t_hoTen.Location = new System.Drawing.Point(76, 65);
            this.t_hoTen.Name = "t_hoTen";
            this.t_hoTen.Size = new System.Drawing.Size(100, 22);
            this.t_hoTen.TabIndex = 3;
            // 
            // l_hoTen
            // 
            this.l_hoTen.AutoSize = true;
            this.l_hoTen.Location = new System.Drawing.Point(19, 68);
            this.l_hoTen.Name = "l_hoTen";
            this.l_hoTen.Size = new System.Drawing.Size(55, 17);
            this.l_hoTen.TabIndex = 2;
            this.l_hoTen.Text = "Ho Ten";
            // 
            // l_mssv
            // 
            this.l_mssv.AutoSize = true;
            this.l_mssv.Location = new System.Drawing.Point(19, 34);
            this.l_mssv.Name = "l_mssv";
            this.l_mssv.Size = new System.Drawing.Size(46, 17);
            this.l_mssv.TabIndex = 1;
            this.l_mssv.Text = "MSSV";
            // 
            // t_mssv
            // 
            this.t_mssv.Location = new System.Drawing.Point(76, 31);
            this.t_mssv.Name = "t_mssv";
            this.t_mssv.Size = new System.Drawing.Size(100, 22);
            this.t_mssv.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Name,
            this.Lop,
            this.Birthday,
            this.Gender,
            this.NNLT});
            this.dataGridView1.Location = new System.Drawing.Point(43, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lop";
            this.Lop.Name = "Lop";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // NNLT
            // 
            this.NNLT.HeaderText = "NNLT";
            this.NNLT.Name = "NNLT";
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(77, 531);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 2;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(159, 531);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(241, 531);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(492, 531);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // t_searchBox
            // 
            this.t_searchBox.Location = new System.Drawing.Point(633, 531);
            this.t_searchBox.Name = "t_searchBox";
            this.t_searchBox.Size = new System.Drawing.Size(100, 22);
            this.t_searchBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(915, 618);
            this.Controls.Add(this.t_searchBox);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_sinhVien);
            this.Name.HeaderText = "Form1";
            this.gb_sinhVien.ResumeLayout(false);
            this.gb_sinhVien.PerformLayout();
            this.gb_nnlt.ResumeLayout(false);
            this.gb_nnlt.PerformLayout();
            this.gb_gioiTinh.ResumeLayout(false);
            this.gb_gioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sinhVien;
        private System.Windows.Forms.GroupBox gb_nnlt;
        private System.Windows.Forms.CheckBox cb_aspnetmvc;
        private System.Windows.Forms.CheckBox cb_vb;
        private System.Windows.Forms.CheckBox cb_csharp;
        private System.Windows.Forms.GroupBox gb_gioiTinh;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Label l_ngaySinh;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.TextBox t_hoTen;
        private System.Windows.Forms.Label l_hoTen;
        private System.Windows.Forms.Label l_mssv;
        private System.Windows.Forms.TextBox t_mssv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNLT;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox t_searchBox;
        private System.Windows.Forms.ComboBox t_khoa;
        private System.Windows.Forms.Label l_khoa;
        private System.Windows.Forms.Button button1;
    }
}

