using System.Data.SqlClient;

namespace SqlJoin
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
            this.label_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label_class = new System.Windows.Forms.Label();
            this.cbb_class = new System.Windows.Forms.ComboBox();
            this.label_birthday = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lv_list = new System.Windows.Forms.ListView();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.gb_gender = new System.Windows.Forms.GroupBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.cbb_facultyid = new System.Windows.Forms.ComboBox();
            this.tb_facultyname = new System.Windows.Forms.TextBox();
            this.label_facultyid = new System.Windows.Forms.Label();
            this.label_facultyName = new System.Windows.Forms.Label();
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.gb_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(37, 31);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 17);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(90, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(121, 22);
            this.tb_id.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(37, 62);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(90, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(187, 22);
            this.tb_name.TabIndex = 3;
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(37, 92);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(42, 17);
            this.label_class.TabIndex = 4;
            this.label_class.Text = "Class";
            // 
            // cbb_class
            // 
            this.cbb_class.FormattingEnabled = true;
            this.cbb_class.Location = new System.Drawing.Point(90, 83);
            this.cbb_class.Name = "cbb_class";
            this.cbb_class.Size = new System.Drawing.Size(121, 24);
            this.cbb_class.TabIndex = 5;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Location = new System.Drawing.Point(399, 28);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(60, 17);
            this.label_birthday.TabIndex = 6;
            this.label_birthday.Text = "Birthday";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Location = new System.Drawing.Point(475, 25);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(264, 22);
            this.dtp_birthday.TabIndex = 7;
            // 
            // lv_list
            // 
            this.lv_list.FullRowSelect = true;
            this.lv_list.Location = new System.Drawing.Point(40, 187);
            this.lv_list.Name = "lv_list";
            this.lv_list.Size = new System.Drawing.Size(699, 191);
            this.lv_list.TabIndex = 10;
            this.lv_list.UseCompatibleStateImageBehavior = false;
            this.lv_list.View = System.Windows.Forms.View.Details;
            this.lv_list.SelectedIndexChanged += new System.EventHandler(this.lv_list_SelectedIndexChanged);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(40, 411);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 11;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(121, 411);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(202, 411);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(283, 411);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(456, 411);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(556, 411);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(183, 22);
            this.tb_search.TabIndex = 12;
            // 
            // gb_gender
            // 
            this.gb_gender.Controls.Add(this.rb_female);
            this.gb_gender.Controls.Add(this.rb_male);
            this.gb_gender.Location = new System.Drawing.Point(402, 57);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Size = new System.Drawing.Size(286, 73);
            this.gb_gender.TabIndex = 13;
            this.gb_gender.TabStop = false;
            this.gb_gender.Text = "Gender";
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(155, 28);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(75, 21);
            this.rb_female.TabIndex = 10;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.CheckedChanged += new System.EventHandler(this.GenderClick);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(46, 28);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(59, 21);
            this.rb_male.TabIndex = 9;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.GenderClick);
            // 
            // cbb_facultyid
            // 
            this.cbb_facultyid.FormattingEnabled = true;
            this.cbb_facultyid.Location = new System.Drawing.Point(90, 113);
            this.cbb_facultyid.Name = "cbb_facultyid";
            this.cbb_facultyid.Size = new System.Drawing.Size(121, 24);
            this.cbb_facultyid.TabIndex = 14;
            // 
            // tb_facultyname
            // 
            this.tb_facultyname.Location = new System.Drawing.Point(90, 144);
            this.tb_facultyname.Name = "tb_facultyname";
            this.tb_facultyname.Size = new System.Drawing.Size(187, 22);
            this.tb_facultyname.TabIndex = 15;
            // 
            // label_facultyid
            // 
            this.label_facultyid.AutoSize = true;
            this.label_facultyid.Location = new System.Drawing.Point(37, 116);
            this.label_facultyid.Name = "label_facultyid";
            this.label_facultyid.Size = new System.Drawing.Size(29, 17);
            this.label_facultyid.TabIndex = 16;
            this.label_facultyid.Text = "FID";
            // 
            // label_facultyName
            // 
            this.label_facultyName.AutoSize = true;
            this.label_facultyName.Location = new System.Drawing.Point(37, 147);
            this.label_facultyName.Name = "label_facultyName";
            this.label_facultyName.Size = new System.Drawing.Size(51, 17);
            this.label_facultyName.TabIndex = 17;
            this.label_facultyName.Text = "Fname";
            // 
            // dgv_student
            // 
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(848, 187);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(579, 191);
            this.dgv_student.TabIndex = 18;
            this.dgv_student.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_student_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 501);
            this.Controls.Add(this.dgv_student);
            this.Controls.Add(this.label_facultyName);
            this.Controls.Add(this.label_facultyid);
            this.Controls.Add(this.tb_facultyname);
            this.Controls.Add(this.cbb_facultyid);
            this.Controls.Add(this.gb_gender);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lv_list);
            this.Controls.Add(this.dtp_birthday);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.cbb_class);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_gender.ResumeLayout(false);
            this.gb_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.ComboBox cbb_class;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.ListView lv_list;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.GroupBox gb_gender;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.ComboBox cbb_facultyid;
        private System.Windows.Forms.TextBox tb_facultyname;
        private System.Windows.Forms.Label label_facultyid;
        private System.Windows.Forms.Label label_facultyName;
        private System.Windows.Forms.DataGridView dgv_student;
    }
}

