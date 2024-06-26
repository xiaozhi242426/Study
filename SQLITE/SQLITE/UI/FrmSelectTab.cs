using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLITE.UI
{
    public partial class FrmSelectTab : Form
    {
        public FrmSelectTab()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Sqlite.SelectTable(this);
        }

        private void cmbTableShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlite.SelectData(this);
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            Sqlite.AddData(this);
        }
    }
}
