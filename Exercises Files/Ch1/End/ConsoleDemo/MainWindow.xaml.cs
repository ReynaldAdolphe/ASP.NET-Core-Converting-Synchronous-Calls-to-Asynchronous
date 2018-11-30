using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ConsoleDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnReadFile_ClickAsync(object sender, RoutedEventArgs e)
        {
            Task<int> task = new Task<int>(GetCharacterCount);
            task.Start();
            lblCount.Content = "Reading file. Hold your horses...";
            int count = await task; // GetCharacterCount();
            lblCount.Content = count.ToString() +
                                " characters in the data file";
        }

        private int GetCharacterCount()
        {
            int count = 0;
            using (StreamReader r = new StreamReader("C:\\TempContent\\theData.txt"))
            {
                string content = r.ReadToEnd();
                count = content.Length;
                Thread.Sleep(10000);
            }
            return count;
        }
    }
}
