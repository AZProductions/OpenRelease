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

namespace OpenRelease
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : HandyControl.Controls.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((App)App.Current).UpdateSkin(HandyControl.Data.SkinType.Default);
            ModernWpf.ThemeManager.SetRequestedTheme(this, ModernWpf.ElementTheme.Light);
            ModernWpf.Controls.ContentDialog noWifiDialog = new ModernWpf.Controls.ContentDialog()
            {
                Title = "No wifi connection",
                Content = "Check your connection and try again.",
                CloseButtonText = "Ok"
            };
            noWifiDialog.ShowAsync();
        }
    }
}