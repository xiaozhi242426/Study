namespace SleepLock
{
    partial class FrmLockSleep
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreatFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatFrm
            // 
            this.btnCreatFrm.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreatFrm.Location = new System.Drawing.Point(209, 141);
            this.btnCreatFrm.Name = "btnCreatFrm";
            this.btnCreatFrm.Size = new System.Drawing.Size(294, 101);
            this.btnCreatFrm.TabIndex = 0;
            this.btnCreatFrm.Text = "测试 ";
            this.btnCreatFrm.UseVisualStyleBackColor = true;
            this.btnCreatFrm.Click += new System.EventHandler(this.btnCreatFrm_Click);
            // 
            // FrmLockSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 650);
            this.Controls.Add(this.btnCreatFrm);
            this.Name = "FrmLockSleep";
            this.Text = "睡眠锁";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLockSleep_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLockSleep_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatFrm;
    }
}

