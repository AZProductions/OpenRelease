using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using System;
using System.Windows;

namespace OpenRelease
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal void UpdateSkin(SkinType skin)
        {
            SharedResourceDictionary.SharedDictionaries.Clear();
            Resources.MergedDictionaries.Add(ResourceHelper.GetSkin(skin));
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
            });
            Current.MainWindow?.OnApplyTemplate();
        }
    }
}
