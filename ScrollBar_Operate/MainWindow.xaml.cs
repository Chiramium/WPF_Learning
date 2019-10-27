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

namespace ScrollBar_Operate
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScrollToHalfVerticalOffset_Button_Click(object sender, RoutedEventArgs e)
        {
            //  垂直スクロールバーの位置を真ん中に設定
            this.scrollViewer.ScrollToVerticalOffset(this.scrollViewer.ScrollableHeight / 2);
        }
    }
}
