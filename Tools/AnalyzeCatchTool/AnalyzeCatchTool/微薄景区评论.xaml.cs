using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AnalyzeCatchTool.Models;
using AnalyzeCatchTool.Utility;

namespace AnalyzeCatchTool
{
    /// <summary>
    /// 微薄景区评论.xaml 的交互逻辑
    /// </summary>
    public partial class 微薄景区评论 : Window
    {
        public 微薄景区评论()
        {
            InitializeComponent();
        }
        private BackgroundWorker m_BackgroundWorker;// 申明后台对象
        Mutex mt = new Mutex();
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            m_BackgroundWorker.RunWorkerAsync(this);          
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            m_BackgroundWorker = new BackgroundWorker(); // 实例化后台对象

            m_BackgroundWorker.WorkerReportsProgress = true; // 设置可以通告进度
            m_BackgroundWorker.WorkerSupportsCancellation = true; // 设置可以取消

            m_BackgroundWorker.DoWork += new DoWorkEventHandler(DoWork);
            m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);
            m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);
        }


        void DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            SqlDBHepler sqlDB = new SqlDBHepler(CurrentConfiguration.Value.TargetDBConnectionString);
            this.listBox1.Dispatcher.Invoke(
                           new Action(
                               delegate
                               {
                                   this.listBox1.Items.Add(("正在处理！请稍后."));
                               }
                           )
                       );
            DataSet ds = sqlDB.GetDataSet("select *from 景点评论明细 where 同步=0 ");
            string url = string.Empty;
            this.txtUrl.Dispatcher.Invoke(
                           new Action(
                               delegate
                               {
                                   url = this.txtUrl.Text;
                               }
                           )
                       );

            微薄评论接口模板 cs;
            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                i++;
                cs = new 微薄评论接口模板(dr);
                string sss = cs.TransformText();

                if (PostData(url, sss))
                {
                    this.listBox1.Dispatcher.Invoke(
                           new Action(
                               delegate
                               {
                                   this.listBox1.Items.Add(("成功同步" + i + "条数据"));
                               }
                           )
                       );

                    sqlDB.ExecuteNonQuery("update 景点评论明细 set 同步=1 where MID=@MID", new List<SqlParameter> { new SqlParameter("@MID", dr["MID"]) });

                }
                else
                {
                    this.listBox1.Dispatcher.Invoke(
                           new Action(
                               delegate
                               {
                                   this.listBox1.Items.Add(("同步" + i + "条数据 失败"));
                               }
                           )
                       );
                }

            }
        }

        public bool PostData(string url, string data)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            req.Method = "POST";
            byte[] byte1 = System.Text.Encoding.UTF8.GetBytes(data);
            req.ContentLength = byte1.Length;
            req.ContentType = "text/xml";
            Stream requestStream = req.GetRequestStream();
            requestStream.Write(byte1, 0, byte1.Length);
            requestStream.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(res.GetResponseStream(), System.Text.Encoding.UTF8);
            string ret = sr.ReadToEnd();
            return true;
        }

        void UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;

        }


        void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                btnStart.IsEnabled = true;
                MessageBox.Show("Error");
            }
            else if (e.Cancelled)
            {
                btnStart.IsEnabled = true;
                MessageBox.Show("Canceled");
            }
            else
            {
                btnStart.IsEnabled = true;
                this.listBox1.Items.Add("同步完成！");
            }
        }

    }
}
