using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServer
{
    public partial class FrmSql : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["xiaozhi"].ConnectionString;

        public FrmSql()
        {
            InitializeComponent();
        }

        public void ConnectToSqlServer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    txtInfo.Text += $"SELECT TOP 1 * FROM TB_USER WHERE USER_NAME = ''hzkk'' AND USER_PWD = ''hzkk'' AND USER_VALID = ''Y''" + "\r\n";

                    string query = "SELECT TOP 1 * FROM TB_USER WHERE USER_NAME = 'hzkk' AND USER_PWD = 'hzkk' AND USER_VALID = 'Y'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // 输出整条数据
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    txtInfo.Text += reader[i].ToString(); // 以空格分隔每个字段
                                }
                                txtInfo.Text += "\r\n"; // 换行显示下一行数据
                            }
                        }
                    }

                    txtInfo.Text += "connecting to SQL Server: " + "\r\n";

                }
                catch (Exception ex)
                {
                    txtInfo.Text += "Error connecting to SQL Server: " + ex.Message + "\r\n";
                }
            }
        }

        private void btnFindStr_Click(object sender, EventArgs e)
        {
            txtSqlStr.Text = connectionString;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "";
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            ConnectToSqlServer();
        }
    }
}
