using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaceGUI_Csharp
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            FillBox();
        }

        void FillBox()//Combobox
        {
            comboBox1.Items.Add("Students");
            comboBox1.Items.Add("Courses");
            comboBox1.Items.Add("Grades");
            comboBox1.Items.Add("Administrator");
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)//AddStudent
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "insert into software_proj.students_table (Student_ID,First_Name,Last_Name) values ('" + id_txt.Text + "','" + Fname_txt.Text + "','" + Lname_txt.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                using MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_stable();


        }

        private void Button1_Click_1(object sender, EventArgs e)//UpdateStudent
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "update software_proj.students_table set Student_ID = '" + id_txt.Text + "' ,First_Name = '" + Fname_txt.Text + "',Last_Name ='" + Lname_txt.Text + "' where Student_ID = '" + id_txt.Text+ "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_stable();
        }

        private void button2_Click(object sender, EventArgs e)//GenerateButton
        {
            Random rnd = new Random();
            id_txt.Text = rnd.Next(1000000,9999999).ToString();
        }

        private void button3_Click(object sender, EventArgs e)//DeleteStudent
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "delete from software_proj.students_table where Student_ID = '" + id_txt.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_stable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void load_stable()
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select Student_ID,First_Name,Last_Name from software_proj.students_table ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void load_courseTable()
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from software_proj.courses_table ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void load_gradeTable()
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from software_proj.enrollment ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void load_adminTable()
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from software_proj.admin_table ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select Student_ID,First_Name,Last_Name from software_proj.students_table ;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Students")
            {
                //MessageBox.Show("Selected Students");
                load_stable();
                studentBox.Show();
                courseBox.Hide();
                gradeBox.Hide();
                adminbox.Hide();
            }
            else if (comboBox1.Text == "Courses")
            {
               // MessageBox.Show("Selected Courses");
                load_courseTable();
                courseBox.Show();
                studentBox.Hide();
                gradeBox.Hide();
                adminbox.Hide();
            }
            else if (comboBox1.Text == "Grades")
            {
                //MessageBox.Show("Selected Grades");
                load_gradeTable();
                gradeBox.Show();
                courseBox.Hide();
                studentBox.Hide();
                adminbox.Hide();

            }
            else if (comboBox1.Text == "Administrator")
            {
                //MessageBox.Show("Selected Administrator");
                load_adminTable();
                adminbox.Show();
                courseBox.Hide();
                gradeBox.Hide();
                studentBox.Hide();
            }
            else
                MessageBox.Show("Please Select a Database");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "delete from software_proj.courses_table where Course_ID = '" + course_id.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_courseTable();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CourseUpdate_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "update software_proj.courses_table set Course_ID = '" + course_id.Text + "' ,Course_Name = '" + course_name.Text + "',Course_Number ='" + course_num.Text + "',Start_Time = '"+ sTime.Text + "',End_Time = '" + eTime.Text + "',Course_Days = '" + course_date.Text + "',Professor_Name = '" + course_prof.Text + "' where Course_ID = '" + course_id.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated ");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_courseTable();
        }

        private void CourseAdd_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "insert into software_proj.courses_table (Course_ID,Course_Number,Course_Name,Start_Time,End_Time,Course_Days,Professor_Name) values ('" + course_id.Text + "','" + course_num.Text + "','" + course_name.Text + "','"+ sTime.Text + "','"+ eTime.Text + "','"+ course_date.Text + "','"+ course_prof.Text +"') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                using MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_courseTable();
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diag = MessageBox.Show("Do you really wanto to exit?","Exit", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
                Application.ExitThread();
            else if (diag == DialogResult.No)
                e.Cancel = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            double avg = 0;
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "insert into software_proj.enrollment (Student_ID,Course_ID,Exam_1,Exam_2,Final_Exam) values ('" + sID.Text + "','" + cID.Text + "','" + ex1.Text + "','" + ex2.Text + "','" + fEx.Text + "') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                using MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_gradeTable();
        }

        private void fGrade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void courseBox_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "update software_proj.enrollment set Exam_1 = '" + ex1.Text + "' ,Exam_2 = '" + ex2.Text + "',Final_Exam = '" + fEx.Text + "',Final_Grade = '" + "' where Student_ID = '" + sID.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_gradeTable();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "delete from software_proj.enrollment where Student_ID = '" + sID.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_gradeTable();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            Random rnd = new Random();
            int id = rnd.Next(200000, 999999);
            var Query = "insert into software_proj.admin_table (Admin_ID,First_Name,Last_Name) values ('" + id + "','" + adminFname.Text + "','" + adminLname.Text +"') ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                using MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myReader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_adminTable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "update software_proj.admin_table First_Name = '" + adminFname.Text + "' ,Last_Name = '" + adminLname.Text + "' where Admin_ID = '" + admin_ID.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_adminTable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var constring = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            var Query = "delete from software_proj.admin_table where Admin_ID = '" + admin_ID.Text + "' ;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_adminTable();
        }
    }
}
