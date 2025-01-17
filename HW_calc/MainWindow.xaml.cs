﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace HW_calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            if (str == "C") Tb1.Text = "";
            else if (str == "<")
            {
                Tb1.Text = Tb1.Text.Substring(0, Tb1.Text.Length - 1);
                Tb1.SelectionStart = Tb1.Text.Length;
            }
            else if (str == "CE")
            {

            }
            else if(str == "=")
            {
                string value = new DataTable().Compute(Tb1.Text, null).ToString();
                Lb1.Content = value;
                
            }
            
            else
            Tb1.Text += str;

        }
    }
}
