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

namespace DataGrid_Template
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

    //  GenderをComboBoxに表示するためのクラス
    public class GenderComboBoxItem
    {
        //  表示用ラベル
        public string Label { get; set; }
        //  値
        public Gender Value { get; set; }
    }

    //  DataGridに表示するデータ
    public class Person
    {
        //  名前
        public string Name { get; set; }
        //  性別
        public Gender Gender { get; set; }
        //  認証済みユーザーかどうか
        public bool AuthMember { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  コンストラクタ
            //  適当なデータを100件作成
            var data = new ObservableCollection<Person>(
                Enumerable.Range(1, 100).Select(i => new Person
                {
                    Name = "余所見　ちらみ" + i,
                    Gender = i % 2 == 0 ? Gender.Men : Gender.Women,
                    AuthMember = i % 5 == 0
                }));
            //  DataGridに設定
            this.dataGrid.ItemsSource = data;
        }
    }
}
