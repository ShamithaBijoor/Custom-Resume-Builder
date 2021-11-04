using System;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Login
{
    public  class Login
    {
        private void Login(string phoneNumber, string password)
        {
            string connetionString = null;
            SqlConnection connection ;
            SqlCommand command ;
            string sql = null;

            connetionString = "Data Source=DESKTOP-55QECQP\SQLEXPRESS;Initial Catalog=ResumeBuilder;User ID=Shamitha;Password=99459n";
            sql = "SELECT 1 FROM ResumeBuilder.dbo.Members WHERE PhoneNumber = '"+phoneNumber+"' AND Password ='"+password+"'";

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}