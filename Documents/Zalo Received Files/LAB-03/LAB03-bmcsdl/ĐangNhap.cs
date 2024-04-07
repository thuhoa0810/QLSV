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

namespace LAB03_bmcsdl
{
    public partial class ĐangNhap : Form
    {
        // Connection string to your database
        private string connectionString = "Data Source=MSI\\MSSQLSERVERTH;Initial Catalog=QLSVNhom;Integrated Security=True";

        public ĐangNhap()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = txb_MaNV.Text;
            string password = txb_MK.Text;

            // Check if username and password are provided
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Check if username and password exist in the database
            string MANV = IsValidUser(username, password);
            if (MANV != "")
            {
                MessageBox.Show("Login successful!");

                // Truyền MANV từ Form Đăng nhập đến Form Sinh viên
                QLLH formQLLH = new QLLH();
                formQLLH.MANV = MANV;
                formQLLH.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private string IsValidUser(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MANV FROM NHANVIEN WHERE TENDN =  '" + username + "' and MATKHAU = hashbytes('SHA1', '" + password + "')";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetString(0);
                }
            }

            return "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

