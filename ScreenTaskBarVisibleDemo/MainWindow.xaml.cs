using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScreenTaskBarVisibleDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
            InitializeComponent();
        }

        private void ShowButton_OnClick(object sender, RoutedEventArgs e)
        {
            ScreenTaskBar.Show(this);
        }

        private void HideButton_OnClick(object sender, RoutedEventArgs e)
        {
            ScreenTaskBar.Hide(this);
        }

        private void MainWindow_OnStateChanged(object sender, EventArgs e)
        {
           Debug.WriteLine("MainWindow_OnStateChanged"+this.WindowState);
        }
    }

    
}
