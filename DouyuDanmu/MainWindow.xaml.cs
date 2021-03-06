﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DouyuDanmu.ViewModel;

namespace DouyuDanmu
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private TcpDanmu _displayViewModel;
        public MainWindow()
        {
            InitializeComponent();
            _displayViewModel = new TcpDanmu();
            DataContext = _displayViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _displayViewModel.LinkStart();
        }

        //private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        //{
        //    //var control = sender as ScrollViewer;
        //    //control.ScrollToEnd();
        //}

        private void ScrollViewer_MouseLeave(object sender, MouseEventArgs e)
        {
            var control = sender as ScrollViewer;
            control.ScrollToEnd();
        }

        private void ScrollViewer_MouseLeave_1(object sender, MouseEventArgs e)
        {
            var control = sender as ScrollViewer;
            control.ScrollToEnd();
        }
    }
}
