﻿using System;
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

namespace Practic4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vb1_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Viewbox)sender).Margin = new Thickness(25);
        }

        private void vb1_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Viewbox)sender).Margin = new Thickness(70);
        }

    }
}
