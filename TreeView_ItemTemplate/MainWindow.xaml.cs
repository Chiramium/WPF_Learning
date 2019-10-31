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

namespace TreeView_ItemTemplate
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Person
        {
            public string Name { get; set; }
            public List<Person> Children { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.treeView.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name = "余所見　ちらみ",
                    Children = new List<Person>
                    {
                        new Person { Name = "余所見　のぞきみ" },
                        new Person { Name = "余所見　にどみ"},
                        new Person
                        {
                            Name = "木村　松治郎",
                            Children = new List<Person>
                            {
                                new Person { Name = "木村　竹子" },
                                new Person { Name = "木村　梅"}
                            }
                        }
                    }
                },
                new Person
                {
                    Name = "一関　二郎",
                    Children = new List<Person>
                    {
                        new Person { Name = "一関　三四郎"}
                    }
                }
            };
        }
    }
}
