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

namespace DataTemplate
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Star
        {
            public string Name { get; set; }
            public int Number { get; set; }
            public BitmapImage Picture { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();

            //  Make object
            var star = new Star
            {
                Name = "星",
                Number = 5,
                Picture = new BitmapImage(new Uri("Resources/star.png", UriKind.Relative))
            };

            //  ボタンに設定
            this.buttonObject.Content = star;
        }
    }
}
