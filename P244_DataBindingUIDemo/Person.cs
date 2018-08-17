using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Controls;
using System.Globalization;

namespace P244_DataBindingUIDemo
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        string name;
        int age = 100;

        public string Name { get => name; set { name = value; OnChanged("Name"); } }
        public int Age { get => age; set { age = value; OnChanged("Age"); } }
    }

    public class AgeRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!int.TryParse((string)value, out int parsedValue))
                return new ValidationResult(false, "잘못된 숫자 형식이다.");

            if (parsedValue > 90 || parsedValue < 20)
                return new ValidationResult(false, "적절한 나이 입력해야한다 20~90 사이.");

            return ValidationResult.ValidResult;
        }
    }
}
