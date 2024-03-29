﻿using System;
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

namespace ComboBox
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var items = Enumerable.Range(1, 10).Select(i => new Person { Name = "ちらみ" + i, Age = 20 + i }).ToList();

            this.comboBox.ItemsSource = items;
        }
    }
}
