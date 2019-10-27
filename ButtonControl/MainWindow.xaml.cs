using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonControl
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

        //  クリック回数
        private int count1 = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //  sender経由でクリックイベントを発生させたボタンを取得
            var button1 = (Button)sender;
            //  ボタンの表示を更新
            button1.Content = string.Format("{0}回", ++count1);
        }

        //  クリック回数
        private int count2 = 0;
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //  sender経由でクリックイベントを発生させたボタンを取得
            var button2 = (RepeatButton)sender;
            //  ボタンの表示を更新
            button2.Content = string.Format("{0}回", ++count2);
        }
    }
}
