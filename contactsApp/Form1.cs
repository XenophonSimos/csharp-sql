using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace contactsApp
{
    public partial class Form1 : Form
    {
        SqlCommand command;
        string query, output = "";
        SqlDataReader dataReader;

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-LA6V9BT\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();

            query = "INSERT INTO contacts (name,lastname,phonenumber,email) VALUES ('" + nameInput.Text + "','" + lastnameInput.Text + "','" + phoneInput.Text + "','" + emailInput.Text + "')";

            command = new SqlCommand(query, cnn);

            command.ExecuteNonQuery();
            cnn.Close();
            command.Dispose();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            cnn.Open();

            query = "SELECT * FROM contacts WHERE name='" + searchName.Text + "'";

            command = new SqlCommand(query, cnn);
 
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    output = output + dataReader.GetValue(0)
                        + " - " + dataReader.GetValue(1)
                        + " - " + dataReader.GetValue(2)
                        + " - " + dataReader.GetValue(3);

                    MessageBox.Show(output);
                }
            } else
            {
                MessageBox.Show("Name doesn't exist");
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}