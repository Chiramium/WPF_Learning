using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGridControl
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    //  性別
    public enum Gender
    {
        None,
        Men,
        Women
    }

    //  DataGridに表示するデータ
    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public bool AuthMember { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  適当なデータを100件生成
            var data = new ObservableCollection<Person>(
                Enumerable.Range(1, 100).Select(i => new Person
                {
                    Name = "余所見　ちらみ" + i,
                    Gender = i % 2 == 0 ? Gender.Men : Gender.Women,
                    Age = 20 + (i % 50),
                    AuthMember = i % 5 == 0
                }));
            //  DataGridに設定
            this.dataGrid.ItemsSource = data;
        }

        private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            //  プロパティ名をもとに自動生成する列をカスタマイズ
            switch (e.PropertyName)
            {
                case "Name":
                    //  Nameプロパティは  0番目に表示してヘッダーを名前にする
                    e.Column.Header = "名前";
                    e.Column.DisplayIndex = 0;
                    break;

                case "Age":
                    //  Ageプロパティは1番目に表示してヘッダーを年齢にする
                    e.Column.Header = "年齢";
                    e.Column.DisplayIndex = 1;
                    break;

                case "Gender":
                    //  Genderプロパティは表示しない
                    e.Cancel = true;
                    break;

                case "AuthMember":
                    //  AuthMemberプロパティは2番目に表示してヘッダーを承認済みにする
                    e.Column.Header = "承認済み";
                    e.Column.DisplayIndex = 2;
                    break;

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
