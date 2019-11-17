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

namespace WPF_PropertySystem
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    public class Person : DependencyObject
    {
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register(
            "Name", //  プロパティ名を指定
            typeof(string), //  プロパティの型を指定
            typeof(Person), //   プロパティを所有する型を指定
            new PropertyMetadata("default name"));  //  メタデータを指定    ここではデフォルト値を設定

        public static readonly DependencyProperty ChildrenProperty =
            DependencyProperty.Register(
                "Children",
                typeof(List<Person>),
                typeof(Person),
                new PropertyMetadata(new List<Person>()));  //  デフォルト値は共有

        public Person()
        {
            //  デフォルト値をコンストラクタで指定できるようにする
            this.Children = new List<Person>();
        }

        public List<Person> Children
        {
            get { return (List<Person>)GetValue(ChildrenProperty); }
            set { SetValue(ChildrenProperty, value); }
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
            //  GetValue, SetValueの使用例
            var p = new Person();
            //  値を取得
            Console.WriteLine(p.GetValue(Person.NameProperty));
            //  値を設定
            p.SetValue(Person.NameProperty, "ちらみ");
            //  値を取得
            Console.WriteLine(p.GetValue(Person.NameProperty));
            */

            //  Childrenプロパティの使用
            var p1 = new Person();
            var p2 = new Person();

            p1.Children.Add(new Person());
            p2.Children.Add(new Person());

            Console.WriteLine("p1.Children.Count = {0}", p1.Children.Count);
            Console.WriteLine("p2.Children.Count = {0}", p2.Children.Count);
        }
    }
}
