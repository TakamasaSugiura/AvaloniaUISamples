using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        private string _height = "";
        public string Height
        {
            get => _height;
            set => this.RaiseAndSetIfChanged(ref _height, value);
        }

        private string _weight = "";
        public string Weight
        {
            get => _weight;
            set => this.RaiseAndSetIfChanged(ref _weight, value);
        }

        private string _bmi = "";
        public string Bmi
        {
            get => _bmi;
            set => this.RaiseAndSetIfChanged(ref _bmi, value);
        }

        public void CalculateBmi()
        {
            try
            {
                var height = double.Parse(_height);
                var weight = double.Parse(_weight);
                Bmi = (weight / (height * height)).ToString("0.00");
            }
            catch
            {
                Bmi = "Error";
            }
        }

    }
}
