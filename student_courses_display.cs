using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaceGUI_Csharp
{
    public partial class student_courses_display : Form
    {
        static string ID;
        public student_courses_display(string getID)
        {
            ID = getID;   // receive ID from the log in page
            InitializeComponent();
            fill_list_box(getID);
        }

        private void fill_list_box(string getID)
        {

            string querry = "USE software_proj; SELECT * FROM enrollment JOIN students_table USING (Student_ID) JOIN courses_table USING (Course_ID) WHERE Student_ID = " + getID;

            string myConnection = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(querry, myConn);

            myConn.Open();
            adapter.Fill(table);
            listCourse.DataSource = table; // store information which is filled in line 31 into the listBox
            listCourse.DisplayMember = "Course_Name"; // select column need to be displayed
            // courses_list.ValueMember = "student_id";// 

        }

        private void show_exam_grade_by_course()
        {

            string querry = "USE software_proj; SELECT * FROM enrollment JOIN students_table USING (Student_ID) JOIN courses_table USING (Course_ID) WHERE Course_name = '"+ listCourse.Text + "' AND student_id=" + ID;

            string myConnection = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand commandDatabase = new MySqlCommand(querry, myConn);
            commandDatabase.CommandTimeout = 60;
            try
            {
                myConn.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                  //  MessageBox.Show("querry generated"); //check if the querry is succesfully generated


                    while (myReader.Read())
                    {
                       
                        stdID.Text = myReader.GetString("Student_ID");
                       StdFullname.Text = myReader.GetString("First_name") + " " + myReader.GetString("Last_name");
                       exam1.Text = myReader.GetInt32("exam_1").ToString();
                       exam2.Text = myReader.GetInt32("exam_2").ToString();
                       finalExam.Text = myReader.GetInt32("final_exam").ToString();
                       finalGrade.Text = myReader.GetInt32("final_grade").ToString();
                        //ID                    // Password                                   
                        // Console.WriteLine(myReader.GetString(0) + "---" + myReader.GetString(1) + "---" + myReader.GetString(2));
                        // this.Hide();
                        //  Form2 f2 = new Form2(getID);
                        // f2.ShowDialog();
                    }
                }

                else
                {
                   // MessageBox.Show("Succes"); // optional
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NOt Succes: " + ex.Message);
            }
        }


        private void courses_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_exam_grade_by_course();
        }
    









    private void student_courses_display_Load(object sender, EventArgs e)
    {

     }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void listCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_exam_grade_by_course();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void finalExam_Click(object sender, EventArgs e)
        {

        }

        private void student_courses_display_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult diag = MessageBox.Show("Do you really wanto to exit?", "Exit", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
                Application.ExitThread();
            else if (diag == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
