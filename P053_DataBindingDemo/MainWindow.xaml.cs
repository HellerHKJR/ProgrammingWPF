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

namespace P053_DataBindingDemo
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

            names = new Nicknames();
            rootPanel.DataContext = names;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            names.Add(new Nickname(txtName.Text, txtNick.Text));
        }
    }
}
