﻿using Microsoft.Win32;
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files|*.txt";
            openFile.Title = "Select a Text File";

            Nullable<bool> result = openFile.ShowDialog();

            if (result == true)
            {
                Console.WriteLine(openFile.FileName);
                lblPath.Content = openFile.FileName;
                txtMain.Text = File.ReadAllText(openFile.FileName, Encoding.UTF8);
            }
        }

        private void buttonCount_Click(object sender, RoutedEventArgs e)
        {
            lblNResult.Content = CountClass.GetWordsByLength(txtMain.Text, Int32.Parse(txtNCount.Text));

        }
    }
}
