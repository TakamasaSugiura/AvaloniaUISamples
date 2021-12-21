using Avalonia.Threading;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Clock.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly DispatcherTimer _timer;

        private string _hoursMinutes = "";
        public string HoursMinutes
        {
            get => _hoursMinutes;
            set => this.RaiseAndSetIfChanged(ref _hoursMinutes, value);
        }

        private string _seconds = "";
        public string Seconds
        {
            get => _seconds;
            set => this.RaiseAndSetIfChanged(ref _seconds, value);
        }

        private string _date = "";
        public string Date
        {
            get => _date;
            set => this.RaiseAndSetIfChanged(ref _date, value);
        }

        public MainWindowViewModel()
        {
            _timer = new();
            _timer.Interval = new TimeSpan(0,0,0,0,300);
            _timer.Tick += (o, e) =>
            {
                var dt = DateTime.Now;
                Date = dt.ToString("MM/dd (ddd)");
                HoursMinutes = dt.ToString("HH:mm");
                Seconds = dt.ToString("ss");
            };
            _timer.Start();
        }
    }
}
