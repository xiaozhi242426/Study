using SleepLock.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepLock
{
    public partial class FrmLockSleep : Form
    {
        public static DateTime lastActionTime;

        public FrmLockSleep()
        {
            InitializeComponent();
            lastActionTime = DateTime.Now;

            Timer timer = new Timer();
            timer.Interval = 5000; // 每秒检查一次
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - lastActionTime;
            if (elapsedTime.TotalMilliseconds >= 10000) // 5分钟
            {
                LockScreen();
            }
        }

        private void LockScreen()
        {
            MessageBox.Show("屏幕已锁定");
        }

        private void FrmLockSleep_MouseMove(object sender, MouseEventArgs e)
        {
            lastActionTime = DateTime.Now;
        }

        private void FrmLockSleep_KeyDown(object sender, KeyEventArgs e)
        {
            lastActionTime = DateTime.Now;
        }

        private void btnCreatFrm_Click(object sender, EventArgs e)
        {
            FrmText frmText = new FrmText();
            frmText.Show();
        }
    }
}
