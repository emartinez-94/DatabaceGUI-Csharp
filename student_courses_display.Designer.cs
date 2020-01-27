namespace DatabaceGUI_Csharp
{
    partial class student_courses_display
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
            this.listCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exam1 = new System.Windows.Forms.Label();
            this.exam2 = new System.Windows.Forms.Label();
            this.finalGrade = new System.Windows.Forms.Label();
            this.finalExam = new System.Windows.Forms.Label();
            this.StdFullname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stdID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCourse
            // 
            this.listCourse.FormattingEnabled = true;
            this.listCourse.Location = new System.Drawing.Point(6, 19);
            this.listCourse.Name = "listCourse";
            this.listCourse.Size = new System.Drawing.Size(120, 95);
            this.listCourse.TabIndex = 0;
            this.listCourse.SelectedIndexChanged += new System.EventHandler(this.listCourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // exam1
            // 
            this.exam1.AutoSize = true;
            this.exam1.Location = new System.Drawing.Point(238, 19);
            this.exam1.Name = "exam1";
            this.exam1.Size = new System.Drawing.Size(70, 13);
            this.exam1.TabIndex = 3;
            this.exam1.Text = "show Exam 1";
            // 
            // exam2
            // 
            this.exam2.AutoSize = true;
            this.exam2.Location = new System.Drawing.Point(238, 50);
            this.exam2.Name = "exam2";
            this.exam2.Size = new System.Drawing.Size(70, 13);
            this.exam2.TabIndex = 4;
            this.exam2.Text = "show Exam 2";
            // 
            // finalGrade
            // 
            this.finalGrade.AutoSize = true;
            this.finalGrade.Location = new System.Drawing.Point(239, 104);
            this.finalGrade.Name = "finalGrade";
            this.finalGrade.Size = new System.Drawing.Size(90, 13);
            this.finalGrade.TabIndex = 5;
            this.finalGrade.Text = "show Final_grade";
            // 
            // finalExam
            // 
            this.finalExam.AutoSize = true;
            this.finalExam.Location = new System.Drawing.Point(238, 76);
            this.finalExam.Name = "finalExam";
            this.finalExam.Size = new System.Drawing.Size(88, 13);
            this.finalExam.TabIndex = 6;
            this.finalExam.Text = "show Final_exam";
            this.finalExam.Click += new System.EventHandler(this.finalExam_Click);
            // 
            // StdFullname
            // 
            this.StdFullname.AutoSize = true;
            this.StdFullname.Location = new System.Drawing.Point(32, 47);
            this.StdFullname.Name = "StdFullname";
            this.StdFullname.Size = new System.Drawing.Size(35, 13);
            this.StdFullname.TabIndex = 13;
            this.StdFullname.Text = "label7";
            this.StdFullname.Click += new System.EventHandler(this.test_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Exam 1 Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Exam 2 Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Final Exam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Final Grade";
            // 
            // stdID
            // 
            this.stdID.AutoSize = true;
            this.stdID.Location = new System.Drawing.Point(123, 47);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(35, 13);
            this.stdID.TabIndex = 18;
            this.stdID.Text = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stdID);
            this.groupBox1.Controls.Add(this.StdFullname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listCourse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.finalExam);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.exam1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.exam2);
            this.groupBox2.Controls.Add(this.finalGrade);
            this.groupBox2.Location = new System.Drawing.Point(229, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 126);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades and Courses";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // student_courses_display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "student_courses_display";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.student_courses_display_FormClosing);
            this.Load += new System.EventHandler(this.student_courses_display_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exam1;
        private System.Windows.Forms.Label exam2;
        private System.Windows.Forms.Label finalGrade;
        private System.Windows.Forms.Label finalExam;
        private System.Windows.Forms.Label StdFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label stdID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}