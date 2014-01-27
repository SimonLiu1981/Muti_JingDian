using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Loaddata();
      
        }

        private void Loaddata()
        {
            DataSet ds = DataBase.ExecuteDataSet("Select  *   From MAIN.[Job] ");

            dataGridView1.DataSource = ds.Tables[0];
        
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count > 0)
            {
                richTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                txtKeyVal.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }

        }

        

        private void bntDelete_Click(object sender, EventArgs e)
        {
            DataBase.Insert(richTextBox1.Text, "", txtKeyVal.Text);
            Loaddata();
        }

        private void bntRead_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = DataBase.ReaFile("config.xml");
        }

        private void bntdel_Click(object sender, EventArgs e)
        {
             if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells.Count > 0)
            {
                DataBase.delete (int.Parse (dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                Loaddata();
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            string cc = @"Cookie=""woaini""";
            string content = "";
            content = Regex.Replace(cc, @"(?<=Cookie="")(.*?)(?="")", "aaaa");

            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                { 
                
               //

                   string xmldata=   Regex.Replace(dataGridView1.SelectedRows[i].Cells[4].Value.ToString(), @"(?<=Cookie="")(.*?)(?="")", richTextBox2.Text );

                   DataBase.Update(int.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString ()), xmldata);
                }
            
            }
            
        }
    }
}
