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
 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=EM@#!!e8e86six";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from software_proj.admin_table where Admin_ID ='" + this.username_txt.Text + "' and Password='" + this.password_txt.Text + "';",myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while(myReader.Read())
                {
                    count = count = 1;
                }
                if (count == 1)
                {
                    //MessageBox.Show("Username and Password is correct");
                    this.Hide();
                    

                    Student addS = new Student();
                    addS.ShowDialog();

                }
                else
                {
                    try
                    {
                        myReader.Close();
                        SelectCommand = new MySqlCommand("select * from software_proj.students_table where Student_ID ='" + username_txt.Text + "' and Password='" + password_txt.Text + "';", myConn);
                        MySqlDataReader myReader2;
                        myReader2 = SelectCommand.ExecuteReader();
             
                        while (myReader2.Read())
                        {
                            count = count = 1;
                        }
                        if (count == 1)
                        {
                            
                            //MessageBox.Show("Username and Password is correct");
                            string getID = myReader2.GetInt32("Student_ID").ToString(); // Store the student_ID into getID to pass it to student_cousres_display window form
                            this.Hide();
                            student_courses_display student_courses_display = new student_courses_display(getID);
                            student_courses_display.ShowDialog();
                            
                        }
                        else
                            MessageBox.Show("Username and Password is not correct...Please Try Again!!!");
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show(ex.Message);
                    }
                }
                myConn.Close();
                SelectCommand.Dispose();

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
            


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
