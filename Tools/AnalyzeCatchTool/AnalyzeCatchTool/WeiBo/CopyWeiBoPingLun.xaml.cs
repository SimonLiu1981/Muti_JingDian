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
using System.Data;
using Microsoft.Win32;
using System.Xml;
using System.IO;
using 火车头采集复制配制;

namespace AnalyzeCatchTool.WeiBo
{
    /// <summary>
    /// Interaction logic for CopyWeiBoPingLun.xaml
    /// </summary>
    public partial class CopyWeiBoPingLun : Window
    {
        public CopyWeiBoPingLun()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

    

        private void txtValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            int selectedIndex = listView1.SelectedIndex;
            ReplaceItem abc = listView1.SelectedItem as ReplaceItem;
            abc.Key = lableKey.Content.ToString();
            abc.Value = txtValue.Text;

            listView1.Items.Refresh();
        }

        
         
        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = listView1.SelectedIndex;
            ReplaceItem abc = listView1.SelectedItem as ReplaceItem;
            if (abc != null)
            {
                lableKey.Content = abc.Key;
                txtValue.Text = abc.Value;
            }
        }

       

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new Microsoft.Win32.OpenFileDialog();
            op.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            op.RestoreDirectory = true;
            op.Filter = "XML文件|*.xml";
            op.ShowDialog();
            string fileName = op.FileName;
            string xml = File.ReadAllText(fileName);
            LocomotiveAcquisitionCopyConfiguration lconf = Serializer.ConvertToObject<LocomotiveAcquisitionCopyConfiguration>(xml);

            txtBeCopyID.Text = lconf.NeedToCopyJobID.ToString();
            txtRoot.Text = lconf.Root;
            ShowData(lconf.ReplaceList.ReplaceItemCollection);
        }


        private void ShowData(ReplaceItemCollection items)
        {
            
            listView1.Items.Clear();

            foreach (var row in items)
            {
                listView1.Items.Add(row);
            }
        }
    }

   
}
