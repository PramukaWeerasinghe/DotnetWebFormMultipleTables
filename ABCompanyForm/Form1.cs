using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCompanyForm
{
    public partial class Form1 : Form
    {
       const string connectionString = @"Data Source=LAPTOP-CHIRANTH\SQLEXPRESS_14;Initial Catalog=ABCompanyDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String qry,qry1;
            String connection = "Data Source=LAPTOP-CHIRANTH\\SQLEXPRESS_14;Initial Catalog=ABCompanyDB;Integrated Security=True;";
            qry = "INSERT INTO Employee(Name,Age,Emp_Id,Salary,Role) VALUES (@Name,@Age,@Emp_Id,@Salary,@Role)";
            qry1 = "INSERT INTO Department(Dep_Name,Location,Dep_ID,Emp_ID) VALUES (@Dep_Name,@Location,@Dep_ID,@Emp_ID)";
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd =new SqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Name", this.E_Name.Text);
                    cmd.Parameters.AddWithValue("@Age", this.age.Text);
                    cmd.Parameters.AddWithValue("@Emp_Id", this.Emp_Id.Text);
                    cmd.Parameters.AddWithValue("@Salary", this.salary.Text);
                    cmd.Parameters.AddWithValue("@Role", this.role.Text);

                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted");
                    }
                    con.Close();
                }

                using (SqlCommand cmd = new SqlCommand(qry1, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@Dep_Name", this.Dep_Name.Text);
                    cmd.Parameters.AddWithValue("@Location", this.location.Text);
                    cmd.Parameters.AddWithValue("@Dep_Id", this.Dep_Id.Text);
                    cmd.Parameters.AddWithValue("@Emp_Id", this.Emp_Id.Text);

                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Not Inserted");
                    }
                }
                con.Close();
            }

            E_Name.Text = string.Empty;
            age.Text = string.Empty;
            Emp_Id.Text = string.Empty;
            salary.Text = string.Empty;
            role.Text = string.Empty;

            Dep_Name.Text = string.Empty;
            location.Text = string.Empty;
            Dep_Id.Text = string.Empty;
            Emp_Id.Text = string.Empty;




        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBCompanyDBDataSet.Department' table. You can move, or remove it, as needed.
            //this.departmentTableAdapter.Fill(this.aBCompanyDBDataSet.Department);
            // TODO: This line of code loads data into the 'aBCompanyDBDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.aBCompanyDBDataSet1.Employee);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
