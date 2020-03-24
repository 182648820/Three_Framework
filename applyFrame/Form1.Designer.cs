namespace applyFrame
{
    partial class Form1
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.LableAge = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.LableName = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(397, 133);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.Size = new System.Drawing.Size(303, 171);
            this.dataView.TabIndex = 35;
            this.dataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellClick);
            // 
            // LableAge
            // 
            this.LableAge.AutoSize = true;
            this.LableAge.Font = new System.Drawing.Font("宋体", 11F);
            this.LableAge.Location = new System.Drawing.Point(100, 211);
            this.LableAge.Name = "LableAge";
            this.LableAge.Size = new System.Drawing.Size(37, 15);
            this.LableAge.TabIndex = 34;
            this.LableAge.Text = "年龄";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("宋体", 11F);
            this.LabelSex.Location = new System.Drawing.Point(100, 262);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(37, 15);
            this.LabelSex.TabIndex = 33;
            this.LabelSex.Text = "性别";
            // 
            // LableName
            // 
            this.LableName.AutoSize = true;
            this.LableName.Font = new System.Drawing.Font("宋体", 11F);
            this.LableName.Location = new System.Drawing.Point(100, 153);
            this.LableName.Name = "LableName";
            this.LableName.Size = new System.Drawing.Size(52, 15);
            this.LableName.TabIndex = 32;
            this.LableName.Text = "姓名：";
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(171, 262);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(201, 21);
            this.Sex.TabIndex = 31;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(171, 211);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(201, 21);
            this.Age.TabIndex = 30;
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(171, 153);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(201, 21);
            this.pName.TabIndex = 29;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(566, 68);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(58, 30);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 30);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(115, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 30);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 395);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.LableAge);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LableName);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label LableAge;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Label LableName;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

