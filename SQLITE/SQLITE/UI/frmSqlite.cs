using SQLITE.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLITE
{
    public partial class frmSqlite : Form
    {
        public frmSqlite()
        {
            InitializeComponent();
        }

        private void btnCreatDb_Click(object sender, EventArgs e)
        {
            Sqlite.CreatDb();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            Sqlite.CreatTable();
        }

        private void btnSelectTab_Click(object sender, EventArgs e)
        {
            FrmSelectTab frmSelectTable = new FrmSelectTab();
            frmSelectTable.Show();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {

        }
    }
}
