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

namespace Calendar
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  今日より前は選択不可能にする
            this.calendar.BlackoutDates.AddDatesInPast();
            //  翌日から4日間も選択不可能にする
            this.calendar.BlackoutDates.Add(
                new CalendarDateRange(
                    DateTime.Today.AddDays(1),
                    DateTime.Today.AddDays(4)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //　選択された日付を連結して表示
            var selected = string.Join(Environment.NewLine,
                this.calendar.SelectedDates.Select(d => d.ToString()));
            MessageBox.Show(selected);
        }
    }
}
