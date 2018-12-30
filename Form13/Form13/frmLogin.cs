using Form12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form13
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //xác dịnh vị trí của file cấu hình
                string path = Application.StartupPath + @"\configDB.txt";
                string[] lines = { @"Server="+ txtServerName.Text,
                    "Database=" +txtDatabaseName.Text,
                    "User=" +txtUserName.Text,
                    "Pass=" +txtPassword.Text };
                System.IO.File.WriteAllLines(path, lines);
                try
                {
                    //Đọc từ dòng trong file cấu hình lưu vào mảng lines
                    lines = System.IO.File.ReadAllLines(path);
                    //lấy các thông tin kết nối trong mảng lines
                    string ServerName = lines[0].Substring(7);
                    string Database = lines[1].Substring(9);
                    string User = lines[2].Substring(5);
                    string Password = lines[3].Substring(5);
                    //string ServerName = txtServerName.Text.Trim();
                    //string Database = txtDatabaseName.Text.Trim();
                    //string User = txtUserName.Text.Trim();
                    //string Password = txtPassword.Text.Trim();
                    //gọi phương thức mở kết nối trong lớp UtilityDB
                    UtilityDB db = new UtilityDB();
                    db.OpenConnection(ServerName, Database, User, Password);
                    db.CloseConnection();

                    this.Hide();
                    frmMain frm = new frmMain(ServerName, Database, User, Password);
                    frm.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối cơ sở dữ liệu, kiểm tra lại thông tin kết nối");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi ghi file cấu hình");
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
