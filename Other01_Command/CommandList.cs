using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Other01_Command
{
    public class AddCommand : ICommand
    {
        private string desc = "Add";
        public string DESC { get => desc; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine("Add 명령 실행");
        }

        public AddCommand()
        {
            Console.WriteLine("AddCommand Constructor");
        }
    }
}
