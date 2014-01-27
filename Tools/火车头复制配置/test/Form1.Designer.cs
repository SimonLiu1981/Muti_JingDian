namespace test
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtKeyVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntdel = new System.Windows.Forms.Button();
            this.bntRead = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(787, 199);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(590, 123);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // txtKeyVal
            // 
            this.txtKeyVal.Location = new System.Drawing.Point(59, 227);
            this.txtKeyVal.Name = "txtKeyVal";
            this.txtKeyVal.Size = new System.Drawing.Size(153, 21);
            this.txtKeyVal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "关键字";
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(139, 488);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(73, 24);
            this.bntSave.TabIndex = 5;
            this.bntSave.Text = "保存";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntdel
            // 
            this.bntdel.Location = new System.Drawing.Point(227, 488);
            this.bntdel.Name = "bntdel";
            this.bntdel.Size = new System.Drawing.Size(75, 23);
            this.bntdel.TabIndex = 6;
            this.bntdel.Text = "删除";
            this.bntdel.UseVisualStyleBackColor = true;
            this.bntdel.Click += new System.EventHandler(this.bntdel_Click);
            // 
            // bntRead
            // 
            this.bntRead.Location = new System.Drawing.Point(665, 264);
            this.bntRead.Name = "bntRead";
            this.bntRead.Size = new System.Drawing.Size(66, 23);
            this.bntRead.TabIndex = 7;
            this.bntRead.Text = "XML读取";
            this.bntRead.UseVisualStyleBackColor = true;
            this.bntRead.Click += new System.EventHandler(this.bntRead_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(58, 488);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 8;
            this.bntDelete.Text = "新增";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "配置文件";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(59, 393);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(590, 67);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "cookies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntRead);
            this.Controls.Add(this.bntdel);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyVal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtKeyVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntdel;
        private System.Windows.Forms.Button bntRead;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
    }
}

