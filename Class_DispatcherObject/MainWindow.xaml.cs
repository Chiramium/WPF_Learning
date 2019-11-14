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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Class_DispatcherObject
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    public class DrivedObject : DispatcherObject
    {
        public void DoSomething()
        {
            //  UIスレッドからのアクセスかチェック
            this.VerifyAccess();
            Debug.WriteLine("DoSomething");
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            //  UIスレッドからの普通の呼び出しなのでOK
            var d = new DrivedObject();
            d.DoSomething();
        }

        private async void NGButton_Click(object sender, RoutedEventArgs e)
        {
            //  UIスレッド以外からの呼び出しなので例外が発生
            var d = new DrivedObject();
            try
            {
                await Task.Run(() => d.DoSomething());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private async void DispatcherButton_Click(object sender, RoutedEventArgs e)
        {
            //  UIスレッド以外だがDispatcher経由での呼び出しなのでOK
            var d = new DrivedObject();
            await Task.Run(async () =>
            {
                if (!d.CheckAccess())
                {
                    await d.Dispatcher.InvokeAsync(() => d.DoSomething());  //    OK
                }
            });
        }
    }
}
