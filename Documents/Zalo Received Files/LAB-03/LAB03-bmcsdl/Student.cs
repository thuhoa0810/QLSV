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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB03_bmcsdl
{
    public partial class SINHVIEN : Form
    {
        public string MANV {  get; set; }
        public SINHVIEN()
        {
            InitializeComponent();
        }

        string connString = "Data Source=MSI\\MSSQLSERVERTH;Initial Catalog=QLSVNhom;Integrated Security=True";

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            // Không tự động focus vào textbox để tránh validation dư thừa
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    (control as System.Windows.Forms.TextBox).TabStop = false;
                }
            }

            // Đổ data vào comboBox Mã Lớp
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Thực hiện truy vấn để lấy dữ liệu từ CSDL
                string query = "SELECT MALOP FROM LOP";

                // Sử dụng SqlDataAdapter để lấy dữ liệu từ CSDL vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Đổ dữ liệu từ DataTable vào ComboBox
                cboMALOP.DataSource = dataTable;
                cboMALOP.DisplayMember = "MALOP";
                cboMALOP.ValueMember = "MALOP";
            }
        }

        private void cboMALOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MALOP = cboMALOP.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(MALOP))
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Thực hiện truy vấn để lấy dữ liệu từ CSDL
                string query = "SELECT MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN FROM SINHVIEN " +
                                "WHERE MALOP = '" + @MALOP + "'";

                // Sử dụng SqlDataAdapter để lấy dữ liệu từ CSDL vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // Đổ dữ liệu vào datagridView
                var ds = new DataSet();
                da.Fill(ds);
                dtgv_SV.DataSource = ds.Tables[0];
            }

        }

        private void dtgv_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra đã chọn hay chưa ?
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgv_SV.Rows[e.RowIndex];
                
                // Display trên các fields
                txtMASV.Text = selectedRow.Cells["MASV"].Value.ToString();
                txtHOTEN.Text = selectedRow.Cells["HOTEN"].Value.ToString();
                dateNGAYSINH.Value = (DateTime)selectedRow.Cells["NGAYSINH"].Value;
                txtDIACHI.Text = selectedRow.Cells["DIACHI"].Value.ToString();
                txtTENDN.Text = selectedRow.Cells["TENDN"].Value.ToString();
                cboMALOP.Text = selectedRow.Cells["MALOP"].Value.ToString();
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            lblWarning.Text = "* Tìm kiếm sinh viên *\n\n  ➖ Nhập MSSV để tìm kiếm thông tin sinh viên\n\n ➖ Thông tin sinh viên hợp lệ sẽ hiện ở danh sách bên dưới";

            string MASV = txtMASV.Text;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Thực hiện SP từ SQL SERVER
                SqlCommand cmd = new SqlCommand("SP_SEL_MASV_SINHVIEN", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào stored procedure (nếu cần)
                cmd.Parameters.AddWithValue("@MASV", txtMASV.Text);

                // Sử dụng SqlDataAdapter để lấy dữ liệu từ CSDL vào DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // Đổ dữ liệu vào datagridView
                var ds = new DataSet();
                da.Fill(ds);
                dtgv_SV.DataSource = ds.Tables[0];
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (isPermission(cboMALOP.SelectedValue.ToString()))
            {
                lblWarning.Text = "* Thêm sinh viên *\n\n ➖ Vui lòng không để trống các thông tin quan trọng";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        // Tạo SqlCommand để thực thi stored procedure
                        SqlCommand cmd = new SqlCommand("SP_INS_SINHVIEN", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Thêm các tham số để INSERT 
                        cmd.Parameters.AddWithValue("@MASV", txtMASV.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", txtHOTEN.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", dateNGAYSINH.Value);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                        cmd.Parameters.AddWithValue("@MALOP", cboMALOP.Text);
                        cmd.Parameters.AddWithValue("@TENDN", txtTENDN.Text);
                        cmd.Parameters.AddWithValue("@MATKHAU", txtMATKHAU.Text);

                        // Mở kết nối
                        connection.Open();

                        // Thực thi stored procedure
                        int rowEffect = cmd.ExecuteNonQuery();

                        // Kiểm tra thêm thành công
                        if (rowEffect > 0)
                        {
                            string mess = "Thêm Sinh viên với Mã số '" + txtMASV.Text + "' thành công";
                            MessageBox.Show(mess, "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridView(cboMALOP.Text);
                        }
                        else
                        {
                            MessageBox.Show("Thêm sinh viên thất bại", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhân viên không được chỉnh sửa thông tin sinh viên Lớp khác");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (isPermission(cboMALOP.SelectedValue.ToString()))
            {
                lblWarning.Text = "* Chỉnh sửa thông tin sinh viên *\n\n  ➖ Hãy chọn 1 sinh viên trong danh sách để thay đổi thông tin\n  ➖ Vui lòng không để trống các thông tin quan trọng";
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        // Tạo SqlCommand để thực thi stored procedure
                        SqlCommand cmd = new SqlCommand("SP_UPD_SINHVIEN", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Thêm các tham số để INSERT 
                        cmd.Parameters.AddWithValue("@MASV", txtMASV.Text);
                        cmd.Parameters.AddWithValue("@HOTEN", txtHOTEN.Text);
                        cmd.Parameters.AddWithValue("@NGAYSINH", dateNGAYSINH.Value);
                        cmd.Parameters.AddWithValue("@DIACHI", txtDIACHI.Text);
                        cmd.Parameters.AddWithValue("@MALOP", cboMALOP.Text);
                        cmd.Parameters.AddWithValue("@TENDN", txtTENDN.Text);
                        cmd.Parameters.AddWithValue("@MATKHAU", txtMATKHAU.Text);

                        // Mở kết nối
                        connection.Open();

                        // Thực thi stored procedure
                        int rowAffect = cmd.ExecuteNonQuery();

                        // Kiểm tra update thành công
                        if (rowAffect > 0)
                        {
                            string mess = "Chỉnh sửa Sinh viên với Mã số '" + txtMASV.Text + "' thành công";
                            MessageBox.Show(mess, "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridView(cboMALOP.Text);
                        }
                        else
                        {
                            MessageBox.Show("Chỉnh sửa sinh viên thất bại", "Chỉnh sửa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhân viên không được chỉnh sửa thông tin sinh viên Lớp khác");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (isPermission(cboMALOP.SelectedValue.ToString()))
            {
                lblWarning.Text = "* Xóa thông tin sinh viên *\n\n  ➖ Hãy chọn 1 sinh viên trong danh sách để xóa\n  ➖ Vui lòng không để trống ô MSSV";

                if (string.IsNullOrEmpty(txtMASV.Text))
                {
                    txtMASV.Focus();
                    errorProvider1.SetError(txtMASV, "Vui lòng không để trống !");
                    return;
                }

                // Xác nhận xóa Dialog
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên có MSSV là " + txtMASV.Text + " không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        // Tạo SqlCommand để thực thi SP từ cơ sở dữ liệu
                        SqlCommand cmd = new SqlCommand("SP_DEL_SINHVIEN", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("MASV", txtMASV.Text);

                        connection.Open();

                        int rowAffect = cmd.ExecuteNonQuery();

                        if (rowAffect > 0)
                        {
                            string mess = "Xóa Sinh viên với Mã số '" + txtMASV.Text + "' thành công";
                            MessageBox.Show(mess, "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataIntoDataGridView(cboMALOP.Text);
                        }
                        else
                        {
                            MessageBox.Show("Xóa sinh viên thất bại", "Xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhân viên không được chỉnh sửa thông tin sinh viên Lớp khác");
            }
        }

        private void txtMASV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMASV.Text))
            {
                e.Cancel = true;
                txtMASV.Focus();
                errorProvider1.SetError(txtMASV,"Vui lòng không để trống !");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txtMASV, null);
            }
        }

        private void txtHOTEN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHOTEN.Text))
            {
                e.Cancel = true;
                txtHOTEN.Focus();
                errorProvider1.SetError(txtHOTEN, "Vui lòng không để trống !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHOTEN, null);
            }
        }

        private void txtTENDN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTENDN.Text))
            {
                e.Cancel = true;
                txtTENDN.Focus();
                errorProvider1.SetError(txtTENDN, "Vui lòng không để trống !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTENDN, null);
            }
        }

        private void LoadDataIntoDataGridView(string MALOP)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Tạo SqlCommand để thực thi truy vấn lấy dữ liệu từ cơ sở dữ liệu
                SqlCommand cmd = new SqlCommand("SELECT * FROM SINHVIEN WHERE MALOP = '" + cboMALOP + "'", connection);

                // Tạo SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                // Mở kết nối
                connection.Open();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Đặt DataTable làm nguồn dữ liệu cho DataGridView
                dtgv_SV.DataSource = dataTable;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMASV.Text = "";
            txtHOTEN.Text = "";
            txtDIACHI.Text = "";
            dateNGAYSINH.Value = DateTime.Now;
            txtTENDN.Text = "";
            txtMATKHAU.Text = "";
            lblWarning.Text = "";
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (dtgv_SV.SelectedCells.Count > 0 && dtgv_SV.SelectedCells[0].Value != null)
            {
                DIEM formDiem = new DIEM();
                formDiem.MASV = txtMASV.Text;
                formDiem.Show();
            }
            else
            {
                lblWarning.Text = "* Xem điểm sinh viên *\n\n  ➖ Hãy chọn 1 sinh viên trong danh sách bên dưới\n\n ➖ Vui lòng không chọn ô rỗng";
            }
        }

        public bool isPermission(string MALOP)
        {
            using(SqlConnection connection = new SqlConnection(connString))
            {
                // Tạo SqlCommand để thực thi SP từ cơ sở dữ liệu
                SqlCommand cmd = new SqlCommand("SP_SEL_MANV_LOP", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MALOP", MALOP);

                connection.Open();

                // Thực thi stored procedure và đọc kết quả
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Đọc giá trị MANV từ kết quả trả về
                        string manvFromDB = reader.GetString(reader.GetOrdinal("MANV"));

                        // So sánh giá trị MANV với giá trị mong muốn
                        if (MANV == manvFromDB)
                        {
                            return true; // MANV tìm thấy trong kết quả trả về
                        }
                    }
                }
                return false;
            }
        }
    }
}
