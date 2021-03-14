using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLPracticeWithCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            ExecNQ("INSERT INTO Businesss (Owner,BusinessName,Employees) VALUES('" + txtBoxOwner.Text + "','" + txtBoxBusiness.Text + "','"+txtBoxEmp.Text+"')");
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            ExecNQ($"DELETE Businesss WHERE ID={txtBoxID.Text}");
        }
        private void ExecNQ(string commTXT)
        {
            string connectString = @"Data Source=MARIK\SQLEXPRESS;Initial Catalog=BusinessDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectString);

            con.Open();
            SqlCommand command = new SqlCommand(commTXT, con);
            int res = command.ExecuteNonQuery(); //Insert,Update,Delete - when we want to use this command need NonQuery

            con.Close();
            MessageBox.Show((res == 1 ? "" : "not") + "succeeded");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ExecNQ($" UPDATE Businesss Set Name='{txtBoxOwner.Text}' " +
                $", BusinessName='{txtBoxBusiness.Text}'"+
                $", Employees='{txtBoxEmp.Text}'"
                + $"WHERE ID='{txtBoxID.Text}'");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string output = "";
            string connectString = @"Data Source=MARIK\SQLEXPRESS;Initial Catalog=BusinessDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectString);
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM Businesss " +
                "Order By Name", con);
            con.Open();
            
            
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                output += reader[0]+ ", "+reader["Owner"]+" , "+reader["BusinessName"] + " , " + reader["Employees"]+"\n";
            }
            con.Close();
            lblUsers.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxBusiness_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
