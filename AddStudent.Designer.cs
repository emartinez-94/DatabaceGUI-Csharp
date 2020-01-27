namespace DatabaceGUI_Csharp
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lname_txt = new System.Windows.Forms.TextBox();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.studentBox = new System.Windows.Forms.GroupBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.software_projDataSet = new DatabaceGUI_Csharp.software_projDataSet();
            this.softwareprojDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.courseBox = new System.Windows.Forms.GroupBox();
            this.Professor = new System.Windows.Forms.Label();
            this.course_prof = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eTime = new System.Windows.Forms.TextBox();
            this.sTime = new System.Windows.Forms.TextBox();
            this.course_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.course_num = new System.Windows.Forms.TextBox();
            this.CourseDelete = new System.Windows.Forms.Button();
            this.CourseUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.course_date = new System.Windows.Forms.TextBox();
            this.CourseAdd = new System.Windows.Forms.Button();
            this.course_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradeBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ex2 = new System.Windows.Forms.TextBox();
            this.sID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.fEx = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ex1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.adminbox = new System.Windows.Forms.GroupBox();
            this.admin_ID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.adminFname = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.adminLname = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.studentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_projDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareprojDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.courseBox.SuspendLayout();
            this.gradeBox.SuspendLayout();
            this.adminbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // Lname_txt
            // 
            this.Lname_txt.Location = new System.Drawing.Point(122, 108);
            this.Lname_txt.Name = "Lname_txt";
            this.Lname_txt.Size = new System.Drawing.Size(100, 20);
            this.Lname_txt.TabIndex = 4;
            // 
            // Fname_txt
            // 
            this.Fname_txt.Location = new System.Drawing.Point(122, 66);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(100, 20);
            this.Fname_txt.TabIndex = 5;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(89, 157);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Add";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // studentBox
            // 
            this.studentBox.Controls.Add(this.id_txt);
            this.studentBox.Controls.Add(this.button3);
            this.studentBox.Controls.Add(this.button1);
            this.studentBox.Controls.Add(this.label1);
            this.studentBox.Controls.Add(this.button2);
            this.studentBox.Controls.Add(this.Lname_txt);
            this.studentBox.Controls.Add(this.save_btn);
            this.studentBox.Controls.Add(this.Fname_txt);
            this.studentBox.Controls.Add(this.label2);
            this.studentBox.Controls.Add(this.label3);
            this.studentBox.Location = new System.Drawing.Point(39, 111);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(348, 230);
            this.studentBox.TabIndex = 7;
            this.studentBox.TabStop = false;
            this.studentBox.Text = "Student";
            this.studentBox.Visible = false;
            this.studentBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(122, 22);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 20);
            this.id_txt.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 397);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // software_projDataSet
            // 
            this.software_projDataSet.DataSetName = "software_projDataSet";
            this.software_projDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareprojDataSetBindingSource
            // 
            this.softwareprojDataSetBindingSource.DataSource = this.software_projDataSet;
            this.softwareprojDataSetBindingSource.Position = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(411, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 422);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(39, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 64);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Databse";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // courseBox
            // 
            this.courseBox.Controls.Add(this.Professor);
            this.courseBox.Controls.Add(this.course_prof);
            this.courseBox.Controls.Add(this.label8);
            this.courseBox.Controls.Add(this.eTime);
            this.courseBox.Controls.Add(this.sTime);
            this.courseBox.Controls.Add(this.course_id);
            this.courseBox.Controls.Add(this.label7);
            this.courseBox.Controls.Add(this.course_num);
            this.courseBox.Controls.Add(this.CourseDelete);
            this.courseBox.Controls.Add(this.CourseUpdate);
            this.courseBox.Controls.Add(this.label4);
            this.courseBox.Controls.Add(this.course_date);
            this.courseBox.Controls.Add(this.CourseAdd);
            this.courseBox.Controls.Add(this.course_name);
            this.courseBox.Controls.Add(this.label5);
            this.courseBox.Controls.Add(this.label6);
            this.courseBox.Location = new System.Drawing.Point(39, 111);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(348, 329);
            this.courseBox.TabIndex = 18;
            this.courseBox.TabStop = false;
            this.courseBox.Text = "Courses";
            this.courseBox.Visible = false;
            this.courseBox.Enter += new System.EventHandler(this.courseBox_Enter);
            // 
            // Professor
            // 
            this.Professor.AutoSize = true;
            this.Professor.Location = new System.Drawing.Point(32, 239);
            this.Professor.Name = "Professor";
            this.Professor.Size = new System.Drawing.Size(51, 13);
            this.Professor.TabIndex = 19;
            this.Professor.Text = "Professor";
            // 
            // course_prof
            // 
            this.course_prof.Location = new System.Drawing.Point(122, 236);
            this.course_prof.Name = "course_prof";
            this.course_prof.Size = new System.Drawing.Size(100, 20);
            this.course_prof.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Start/End Time";
            // 
            // eTime
            // 
            this.eTime.Location = new System.Drawing.Point(181, 169);
            this.eTime.Name = "eTime";
            this.eTime.Size = new System.Drawing.Size(41, 20);
            this.eTime.TabIndex = 16;
            // 
            // sTime
            // 
            this.sTime.Location = new System.Drawing.Point(122, 169);
            this.sTime.Name = "sTime";
            this.sTime.Size = new System.Drawing.Size(42, 20);
            this.sTime.TabIndex = 15;
            // 
            // course_id
            // 
            this.course_id.Location = new System.Drawing.Point(122, 48);
            this.course_id.Name = "course_id";
            this.course_id.Size = new System.Drawing.Size(100, 20);
            this.course_id.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Course ID";
            // 
            // course_num
            // 
            this.course_num.Location = new System.Drawing.Point(122, 92);
            this.course_num.Name = "course_num";
            this.course_num.Size = new System.Drawing.Size(100, 20);
            this.course_num.TabIndex = 9;
            // 
            // CourseDelete
            // 
            this.CourseDelete.Location = new System.Drawing.Point(147, 300);
            this.CourseDelete.Name = "CourseDelete";
            this.CourseDelete.Size = new System.Drawing.Size(75, 23);
            this.CourseDelete.TabIndex = 12;
            this.CourseDelete.Text = "Delete";
            this.CourseDelete.UseVisualStyleBackColor = true;
            this.CourseDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // CourseUpdate
            // 
            this.CourseUpdate.Location = new System.Drawing.Point(210, 271);
            this.CourseUpdate.Name = "CourseUpdate";
            this.CourseUpdate.Size = new System.Drawing.Size(75, 23);
            this.CourseUpdate.TabIndex = 9;
            this.CourseUpdate.Text = "Update";
            this.CourseUpdate.UseVisualStyleBackColor = true;
            this.CourseUpdate.Click += new System.EventHandler(this.CourseUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Course Number";
            // 
            // course_date
            // 
            this.course_date.Location = new System.Drawing.Point(122, 204);
            this.course_date.Name = "course_date";
            this.course_date.Size = new System.Drawing.Size(100, 20);
            this.course_date.TabIndex = 4;
            // 
            // CourseAdd
            // 
            this.CourseAdd.Location = new System.Drawing.Point(89, 271);
            this.CourseAdd.Name = "CourseAdd";
            this.CourseAdd.Size = new System.Drawing.Size(75, 23);
            this.CourseAdd.TabIndex = 6;
            this.CourseAdd.Text = "Add";
            this.CourseAdd.UseVisualStyleBackColor = true;
            this.CourseAdd.Click += new System.EventHandler(this.CourseAdd_Click);
            // 
            // course_name
            // 
            this.course_name.Location = new System.Drawing.Point(122, 131);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(100, 20);
            this.course_name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date(s)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Course Name";
            // 
            // gradeBox
            // 
            this.gradeBox.Controls.Add(this.label10);
            this.gradeBox.Controls.Add(this.ex2);
            this.gradeBox.Controls.Add(this.sID);
            this.gradeBox.Controls.Add(this.label11);
            this.gradeBox.Controls.Add(this.cID);
            this.gradeBox.Controls.Add(this.button5);
            this.gradeBox.Controls.Add(this.button6);
            this.gradeBox.Controls.Add(this.label12);
            this.gradeBox.Controls.Add(this.fEx);
            this.gradeBox.Controls.Add(this.button7);
            this.gradeBox.Controls.Add(this.ex1);
            this.gradeBox.Controls.Add(this.label13);
            this.gradeBox.Controls.Add(this.label14);
            this.gradeBox.Location = new System.Drawing.Point(39, 111);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(348, 344);
            this.gradeBox.TabIndex = 19;
            this.gradeBox.TabStop = false;
            this.gradeBox.Text = "Grades";
            this.gradeBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Exam 2";
            // 
            // ex2
            // 
            this.ex2.Location = new System.Drawing.Point(122, 169);
            this.ex2.Name = "ex2";
            this.ex2.Size = new System.Drawing.Size(100, 20);
            this.ex2.TabIndex = 16;
            // 
            // sID
            // 
            this.sID.Location = new System.Drawing.Point(122, 48);
            this.sID.Name = "sID";
            this.sID.Size = new System.Drawing.Size(100, 20);
            this.sID.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Student ID";
            // 
            // cID
            // 
            this.cID.Location = new System.Drawing.Point(122, 92);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(100, 20);
            this.cID.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(147, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(210, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Course ID";
            // 
            // fEx
            // 
            this.fEx.Location = new System.Drawing.Point(122, 204);
            this.fEx.Name = "fEx";
            this.fEx.Size = new System.Drawing.Size(100, 20);
            this.fEx.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ex1
            // 
            this.ex1.Location = new System.Drawing.Point(122, 131);
            this.ex1.Name = "ex1";
            this.ex1.Size = new System.Drawing.Size(100, 20);
            this.ex1.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Final Exam";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Exam 1";
            // 
            // adminbox
            // 
            this.adminbox.Controls.Add(this.admin_ID);
            this.adminbox.Controls.Add(this.label15);
            this.adminbox.Controls.Add(this.adminFname);
            this.adminbox.Controls.Add(this.button8);
            this.adminbox.Controls.Add(this.button9);
            this.adminbox.Controls.Add(this.label18);
            this.adminbox.Controls.Add(this.button10);
            this.adminbox.Controls.Add(this.adminLname);
            this.adminbox.Controls.Add(this.label20);
            this.adminbox.Location = new System.Drawing.Point(39, 111);
            this.adminbox.Name = "adminbox";
            this.adminbox.Size = new System.Drawing.Size(247, 204);
            this.adminbox.TabIndex = 20;
            this.adminbox.TabStop = false;
            this.adminbox.Text = "Administrator";
            this.adminbox.Visible = false;
            // 
            // admin_ID
            // 
            this.admin_ID.Location = new System.Drawing.Point(129, 21);
            this.admin_ID.Name = "admin_ID";
            this.admin_ID.Size = new System.Drawing.Size(100, 20);
            this.admin_ID.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Administrator ID";
            // 
            // adminFname
            // 
            this.adminFname.Location = new System.Drawing.Point(129, 59);
            this.adminFname.Name = "adminFname";
            this.adminFname.Size = new System.Drawing.Size(100, 20);
            this.adminFname.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(91, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(154, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "First Name";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(25, 136);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // adminLname
            // 
            this.adminLname.Location = new System.Drawing.Point(129, 94);
            this.adminLname.Name = "adminLname";
            this.adminLname.Size = new System.Drawing.Size(100, 20);
            this.adminLname.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Last Name";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.adminbox);
            this.Name = "Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Student_FormClosing);
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.studentBox.ResumeLayout(false);
            this.studentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.software_projDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareprojDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.courseBox.ResumeLayout(false);
            this.courseBox.PerformLayout();
            this.gradeBox.ResumeLayout(false);
            this.gradeBox.PerformLayout();
            this.adminbox.ResumeLayout(false);
            this.adminbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lname_txt;
        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox studentBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource softwareprojDataSetBindingSource;
        private software_projDataSet software_projDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox courseBox;
        private System.Windows.Forms.TextBox course_num;
        private System.Windows.Forms.Button CourseDelete;
        private System.Windows.Forms.Button CourseUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox course_date;
        private System.Windows.Forms.Button CourseAdd;
        private System.Windows.Forms.TextBox course_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eTime;
        private System.Windows.Forms.TextBox sTime;
        private System.Windows.Forms.TextBox course_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Professor;
        private System.Windows.Forms.TextBox course_prof;
        private System.Windows.Forms.GroupBox gradeBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ex2;
        private System.Windows.Forms.TextBox sID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox fEx;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox ex1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox adminbox;
        private System.Windows.Forms.TextBox adminFname;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox adminLname;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox admin_ID;
        private System.Windows.Forms.Label label15;
    }
}