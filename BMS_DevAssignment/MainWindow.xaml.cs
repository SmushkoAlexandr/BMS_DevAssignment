using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace BMS_DevAssignment
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

        private void buttonBrowse_Click(object sender, RoutedEventArgs e)
        {
            Tuple<string, string> getValue = CountClass.OpenFile();

            txtMain.Text = getValue.Item1;
            lblPath.Content = getValue.Item2;
        }

         private void buttonCount_Click(object sender, RoutedEventArgs e)
        {         
            try
            {
                lblNResult.Content = CountClass.GetWordsByLength(txtMain.Text, Int32.Parse(txtNCount.Text));
                lblLetterResult.Content = CountClass.GetCharacterOccurrences(txtMain.Text, Convert.ToChar(txtLetterRepeat.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception. Please, check entered data.");
            }
        }

        private void cbEditText_Checked(object sender, RoutedEventArgs e)
        {
            txtMain.IsReadOnly = false;
        }

        private void cbEditText_Unchecked(object sender, RoutedEventArgs e)
        {
            txtMain.IsReadOnly = true;
        }
    }
}
