using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRelease.components.theme
{
    internal class ThemeChanger
    {
        public static void Change(Theme.ThemeType type) 
        {
            switch (type)
            {
                case Theme.ThemeType.Light:
                    ((App)App.Current).UpdateSkin(HandyControl.Data.SkinType.Default);
                    ModernWpf.ThemeManager.SetRequestedTheme(App.Current.MainWindow, ModernWpf.ElementTheme.Light);
                    break;
                case Theme.ThemeType.Dark:
                    ((App)App.Current).UpdateSkin(HandyControl.Data.SkinType.Dark);
                    ModernWpf.ThemeManager.SetRequestedTheme(App.Current.MainWindow, ModernWpf.ElementTheme.Dark);
                    break;
                default:
                    ((App)App.Current).UpdateSkin(HandyControl.Data.SkinType.Dark);
                    ModernWpf.ThemeManager.SetRequestedTheme(App.Current.MainWindow, ModernWpf.ElementTheme.Dark);
                    break;
            }
        }
    }
}
