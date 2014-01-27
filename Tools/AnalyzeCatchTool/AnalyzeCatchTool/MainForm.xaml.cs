using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AnalyzeCatchTool.Models;
using Microsoft.Win32;
using AnalyzeCatchTool.WeiBo;

namespace AnalyzeCatchTool
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            PrimaryTableAnalyze.motify += new Notify(PrimaryTableAnalyze_motify);
            LoadConfig();
        }

        void PrimaryTableAnalyze_motify(int total, int current)
        {
            progressBar.Maximum = total;
            progressBar.Value = current;
        }
 
        private void btnDo_Click(object sender, RoutedEventArgs e)
        {
            SaveConfig();
            
            PrimaryTableAnalyze.Execute(CurrentConfiguration.Value);
        }

        private void Menu_Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            op.RestoreDirectory = true;
            op.Filter = "XML文件|*.xml";
            op.ShowDialog();
            CurrentConfiguration.path = op.FileName;
            LoadConfig();
        }

        private void Menu_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveConfig();
        }

        private void SaveConfig()
        {
            CurrentConfiguration.Value.BreakDownColumns = txtBreakDownColumns.Text;
            CurrentConfiguration.Value.TargetDBConnectionString = txtTargetDB.Text;
            CurrentConfiguration.Value.SourceDBConnectionString = txtSourceDB.Text;
            CurrentConfiguration.Value.SplitString = txtSplitString.Text;
            CurrentConfiguration.Value.SourceTableName = txtSourceTableName.Text;
            CurrentConfiguration.Value.InstertPrimaryTableTemplate = txtInstertPrimaryTableTemplate.Text;
            CurrentConfiguration.Value.InstertSubTableTemplate = txtInstertSubTableTemplate.Text;
            CurrentConfiguration.Value.CheckRowInstertPrimaryTable = txtCheckRowInstertPrimaryTable.Text;
            CurrentConfiguration.Value.CheckRowInstertSubTable = txtCheckRowInstertSubTable.Text;

            CurrentConfiguration.Save();
        }

        void LoadConfig()
        {
            CurrentConfiguration.Load();
            txtBreakDownColumns.Text = CurrentConfiguration.Value.BreakDownColumns;
            txtTargetDB.Text = CurrentConfiguration.Value.TargetDBConnectionString;
            txtSourceDB.Text = CurrentConfiguration.Value.SourceDBConnectionString;
            txtSplitString.Text = CurrentConfiguration.Value.SplitString;
            txtInstertPrimaryTableTemplate.Text = CurrentConfiguration.Value.InstertPrimaryTableTemplate;
            txtInstertSubTableTemplate.Text = CurrentConfiguration.Value.InstertSubTableTemplate;
            txtCheckRowInstertPrimaryTable.Text = CurrentConfiguration.Value.CheckRowInstertPrimaryTable;
            txtSourceTableName.Text = CurrentConfiguration.Value.SourceTableName;
            txtCheckRowInstertSubTable.Text = CurrentConfiguration.Value.CheckRowInstertSubTable; 
        }

        private void Menu_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Menu_SaveOther_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML文件（*.xml）|*.xml";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            bool? bl = sfd.ShowDialog();

            if (bl.HasValue && bl.Value)
            {
                CurrentConfiguration.path = sfd.FileName;
                SaveConfig();
            }
            
        }

        private void MenuItem_WeiBo_Click(object sender, RoutedEventArgs e)
        {
            微薄景区评论 pl = new 微薄景区评论();
            pl.ShowDialog();
            
        }

        private void MenuItem_CopyWeiBo_Click(object sender, RoutedEventArgs e)
        {
            CopyWeiBoPingLun cwb = new CopyWeiBoPingLun();
            cwb.ShowDialog();
        }
 

        
    }
}
