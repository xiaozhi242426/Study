namespace SqlServer
{
    partial class FrmSql
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
            this.txtSqlStr = new System.Windows.Forms.TextBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnFindStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSqlStr
            // 
            this.txtSqlStr.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSqlStr.Location = new System.Drawing.Point(91, 74);
            this.txtSqlStr.Name = "txtSqlStr";
            this.txtSqlStr.Size = new System.Drawing.Size(1171, 58);
            this.txtSqlStr.TabIndex = 0;
            // 
            // btnCon
            // 
            this.btnCon.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCon.Location = new System.Drawing.Point(614, 162);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(303, 63);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "连接";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInfo.Location = new System.Drawing.Point(91, 260);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(1171, 413);
            this.txtInfo.TabIndex = 2;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClean.Location = new System.Drawing.Point(959, 162);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(303, 63);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "清空";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnFindStr
            // 
            this.btnFindStr.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFindStr.Location = new System.Drawing.Point(91, 162);
            this.btnFindStr.Name = "btnFindStr";
            this.btnFindStr.Size = new System.Drawing.Size(303, 63);
            this.btnFindStr.TabIndex = 4;
            this.btnFindStr.Text = "获取字符串";
            this.btnFindStr.UseVisualStyleBackColor = true;
            this.btnFindStr.Click += new System.EventHandler(this.btnFindStr_Click);
            // 
            // FrmSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 803);
            this.Controls.Add(this.btnFindStr);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtSqlStr);
            this.Name = "FrmSql";
            this.Text = "SqlServer连接测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSqlStr;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnFindStr;
    }
}

