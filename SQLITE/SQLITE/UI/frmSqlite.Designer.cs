namespace SQLITE
{
    partial class frmSqlite
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
            this.btnCreatDb = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnSelectTab = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatDb
            // 
            this.btnCreatDb.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreatDb.Location = new System.Drawing.Point(50, 79);
            this.btnCreatDb.Name = "btnCreatDb";
            this.btnCreatDb.Size = new System.Drawing.Size(299, 127);
            this.btnCreatDb.TabIndex = 0;
            this.btnCreatDb.Text = "创建数据库";
            this.btnCreatDb.UseVisualStyleBackColor = true;
            this.btnCreatDb.Click += new System.EventHandler(this.btnCreatDb_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateTable.Location = new System.Drawing.Point(391, 79);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(299, 127);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "创建表";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnSelectTab
            // 
            this.btnSelectTab.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectTab.Location = new System.Drawing.Point(736, 79);
            this.btnSelectTab.Name = "btnSelectTab";
            this.btnSelectTab.Size = new System.Drawing.Size(299, 127);
            this.btnSelectTab.TabIndex = 2;
            this.btnSelectTab.Text = "查询表";
            this.btnSelectTab.UseVisualStyleBackColor = true;
            this.btnSelectTab.Click += new System.EventHandler(this.btnSelectTab_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddData.Location = new System.Drawing.Point(50, 246);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(299, 127);
            this.btnAddData.TabIndex = 3;
            this.btnAddData.Text = "插入数据";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // frmSqlite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 799);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnSelectTab);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnCreatDb);
            this.Name = "frmSqlite";
            this.Text = "Sqlite测试";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatDb;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnSelectTab;
        private System.Windows.Forms.Button btnAddData;
    }
}

