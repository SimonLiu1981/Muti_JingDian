namespace QuestionImport
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
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateXml = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJingqucode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.标题});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(559, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // 编号
            // 
            this.编号.DataPropertyName = "Seqno";
            this.编号.HeaderText = "Seqno";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            // 
            // 标题
            // 
            this.标题.DataPropertyName = "Title";
            this.标题.HeaderText = "Title";
            this.标题.Name = "标题";
            this.标题.ReadOnly = true;
            // 
            // btnGenerateXml
            // 
            this.btnGenerateXml.Location = new System.Drawing.Point(496, 315);
            this.btnGenerateXml.Name = "btnGenerateXml";
            this.btnGenerateXml.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateXml.TabIndex = 1;
            this.btnGenerateXml.Text = "生成XML";
            this.btnGenerateXml.UseVisualStyleBackColor = true;
            this.btnGenerateXml.Click += new System.EventHandler(this.btnGenerateXml_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(559, 393);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(64, 315);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 21);
            this.txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(208, 315);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 21);
            this.txtEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seqno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "TO";
            // 
            // txtJingqucode
            // 
            this.txtJingqucode.Location = new System.Drawing.Point(392, 315);
            this.txtJingqucode.Name = "txtJingqucode";
            this.txtJingqucode.Size = new System.Drawing.Size(84, 21);
            this.txtJingqucode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "JinQucode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJingqucode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenerateXml);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.Button btnGenerateXml;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJingqucode;
        private System.Windows.Forms.Label label3;
    }
}

