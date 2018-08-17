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

namespace P244_DataBindingUIDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Validation.AddErrorHandler(tmpTextBoxAge, ErrorHandle);
        }

        private void ErrorHandle(object sender, ValidationErrorEventArgs e)
        {
            //tmpTextBoxAge.ToolTip = (string)e.Error.ErrorContent;
            ////MessageBox.Show((string)e.Error.ErrorContent, "유효성검사 오류");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person tom = this.targetGrid.FindResource("Tom") as Person;
            
            tom.Age = new Random().Next(0, 100);
        }
    }
}
