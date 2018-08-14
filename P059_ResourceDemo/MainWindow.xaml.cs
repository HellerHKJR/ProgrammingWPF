using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P059_ResourceDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nicknames names;
        public MainWindow()
        {
            InitializeComponent();

            names = (Nicknames)FindResource("names");
            // 이렇게 할 경우 DataContext를 코드 상에서 지정할 필요가 없다.

            names.Add(new Nickname("XXX", "1st"));
            names.Add(new Nickname("YYY", "2nd"));
            names.Add(new Nickname("ZZZ", "3rd"));
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            names.Add(new Nickname(txtName.Text, txtNick.Text));
        }
    }
}
