using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace note
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存視窗檔案
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當下按儲存之後的反應
            if (result == true)
            {
                // 寫入檔案
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生打開視窗檔案
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當下按打開之後的反應
            if (result == true)
            {
                // 寫入檔案
                Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
            }
        }

        private void A1Btn_Click(object sender, RoutedEventArgs e)
        {
            fsize = A1Btn.FontSize;
            if (fsize == 16.0)
            {
                A1Btn.FontSize = 10.0;
                A1Btn.Content = "FontSize";
            }
            else
            {
                A1Btn.FontSize = 16.0;
                A1Btn.Content = "Control font size changes from 10 to 16.";
            }
    }
}

