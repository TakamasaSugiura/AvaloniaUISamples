using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Counter.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _counter1 = 0;
        public int Counter1
        {
            get => _counter1;
            set => this.RaiseAndSetIfChanged(ref _counter1, value);
        }

        private int _counter2 = 0;
        public int Counter2
        {
            get => _counter2;
            set => this.RaiseAndSetIfChanged(ref _counter2, value);
        }

        private int _counter3 = 0;
        public int Counter3
        {
            get => _counter3;
            set => this.RaiseAndSetIfChanged(ref _counter3, value);
        }

        private int _counter4 = 0;
        public int Counter4
        {
            get => _counter4;
            set => this.RaiseAndSetIfChanged(ref _counter4, value);
        }

        private int _counter5 = 0;
        public int Counter5
        {
            get => _counter5;
            set => this.RaiseAndSetIfChanged(ref _counter5, value);
        }

        private int _counter6 = 0;
        public int Counter6
        {
            get => _counter6;
            set => this.RaiseAndSetIfChanged(ref _counter6, value);
        }

        private int _counter7 = 0;
        public int Counter7
        {
            get => _counter7;
            set => this.RaiseAndSetIfChanged(ref _counter7, value);
        }

        private int _counter8 = 0;
        public int Counter8
        {
            get => _counter8;
            set => this.RaiseAndSetIfChanged(ref _counter8, value);
        }

        private int _counter9 = 0;
        public int Counter9
        {
            get => _counter9;
            set => this.RaiseAndSetIfChanged(ref _counter9, value);
        }

        public void CountUp(int counterNo)
        {
            switch (counterNo)
            {
                case 1:
                    Counter1++;
                    break;
                case 2:
                    Counter2++;
                    break;
                case 3:
                    Counter3++;
                    break;
                case 4:
                    Counter4++;
                    break;
                case 5:
                    Counter5++;
                    break;
                case 6:
                    Counter6++;
                    break;
                case 7:
                    Counter7++;
                    break;
                case 8:
                    Counter8++;
                    break;
                case 9:
                    Counter9++;
                    break;
            }
        }

        public void Clear()
        {
            Counter1 = 0;
            Counter2 = 0;
            Counter3 = 0;
            Counter4 = 0;
            Counter5 = 0;
            Counter6 = 0;
            Counter7 = 0;
            Counter8 = 0;
            Counter9 = 0;
        }

    }
}
