using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace P053_DataBindingDemo
{
    public class Nickname : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string pName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pName));
        }

        string name;
        public string Name { get => name; set { name = value; OnPropertyChange("Name"); } }
        string nick;
        public string Nick { get => nick; set { nick = value; OnPropertyChange("Nick"); } }

        public Nickname() : this("Name", "Nick") { }

        public Nickname(string name, string nick)
        {
            this.name = name;
            this.nick = nick;
        }
    }

    public class Nicknames : ObservableCollection<Nickname> { }
}
