using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SQLITE.UI
{
    public class Sqlite
    {
        public static string connectionString = "Data Source=mydatabase.db;Version=3;";

        /// <summary>
        /// 创建数据库
        /// </summary>
        public static void CreatDb()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS MyTable (Id INTEGER PRIMARY KEY, Name TEXT)";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("SQLite database and table created successfully.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("创建失败: " + e);
            }
        }

        /// <summary>
        /// 创建表
        /// </summary>
        public static void CreatTable()
        {
            FrmCreatTable frmCreatTable = new FrmCreatTable();
            if (frmCreatTable.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string tabelName = frmCreatTable.txtTableName.Text.Trim();
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string createTableQuery = "CREATE TABLE IF NOT EXISTS " + tabelName + " (Id INTEGER PRIMARY KEY, Name TEXT, Salary REAL)";
                        using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Table \"tabelName\" created successfully.");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("创建失败: " + e);
                }
            }

        }

        /// <summary>
        /// 查找所有表
        /// </summary>
        /// <param name="frmSelectTable"></param>
        public static void SelectTable(FrmSelectTab frmSelectTable)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    DataTable tables = connection.GetSchema("Tables");

                    frmSelectTable.cmbTableShow.Items.Clear();

                    foreach (DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        frmSelectTable.cmbTableShow.Items.Add(tableName);
                    }
                }
                MessageBox.Show("查询完成!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查找所有字段
        /// </summary>
        /// <param name="frmSelectTable"></param>
        public static void SelectData(FrmSelectTab frmSelectTable)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM " + frmSelectTable.cmbTableShow.Text;

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        frmSelectTable.txtTableRow.Text = "";
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                double salary = reader.GetDouble(2);

                                frmSelectTable.txtTableRow.Text += $"Id: {id}, Name: {name}, Salary: {salary}" + "\r\n";
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void AddData(FrmSelectTab frmSelectTable)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertDataQuery = $"INSERT INTO {frmSelectTable.cmbTableShow.Text} (Name, Salary) VALUES ('{frmSelectTable.txtOne.Text}', {int.Parse(frmSelectTable.txtTwo.Text)})";
                    using (SQLiteCommand command = new SQLiteCommand(insertDataQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
