using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using BMI.Model;
using BMI.Command;

namespace BMI.ViewModel
{
    //INotifyPropertyChanged 인터페이스 구현(속성 변경 이벤트)
    public class Notifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    //코드 알림 속성  
    public class ConverterViewModel : Notifier
    {
        Person _person = new Person();
        public double Weight
        {
            get { return _person.Weight; }
            set
            {
                _person.Weight = value;
                OnPropertyChanged("Weight");


            }
        }
        public double Tall
        {
            get { return _person.Tall; }
            set
            {
                _person.Tall = value;
                OnPropertyChanged("Tall");
            }
        }
        public string Result
        {
            get { return _person.Result; }
            set
            {
                _person.Result = value;
                OnPropertyChanged("Result");
            }
        }
        private void OnResultChanged()
        {
            //기능적 코드 추가
            const double num = 0.0001;
            double rate = Weight / ((Tall * Tall) * num);

            if (rate <= 18.5)
            {
                Result = "저체중";
            }
            else if (rate > 18.5 && rate <= 22.9)
            {
                Result = "정상";
            }
            else if (rate >= 23.0 && rate <= 24.9)
            {
                Result = "과체중";
            }
            else if (rate >= 25.0)
            {
                Result = "비만";
            }
        }
        //ICommand 
        public ICommand DelegateCommand { get; set; }

        public ConverterViewModel()
        {
            DelegateCommand = new Commands(ExecuteMethod, CanExecuteMethod);
        }

        private void ExecuteMethod(object obj)
        {
            OnResultChanged();
        }

        private bool CanExecuteMethod(object arg)
        {
            return true;
        }
    }
}
