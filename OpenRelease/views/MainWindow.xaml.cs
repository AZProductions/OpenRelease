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
using OpenRelease;
using OpenRelease.components;

namespace OpenRelease
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : HandyControl.Controls.Window
    {
        bool theme = true;
        public MainWindow()
        {
            InitializeComponent();
            components.WindowReference.Window = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (theme)
            {
                components.theme.ThemeChanger.Change(components.theme.Theme.ThemeType.Dark);
                theme = false;
            }
            else
            {
                components.theme.ThemeChanger.Change(components.theme.Theme.ThemeType.Light);
                theme = true;
            }
            ModernWpf.Controls.ContentDialog noWifiDialog = new ModernWpf.Controls.ContentDialog()
            {
                Title = "No wifi connection",
                Content = "Check your connection and try again.",
                CloseButtonText = "Ok"
            };
            noWifiDialog.ShowAsync();
        }

        private void Nav2Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Nav2Combo.SelectedItem == Nav2ComboNewBTN)
                Nav2Combo.SelectedIndex = Nav2Combo.SelectedIndex - 1;
        }
    }
}
