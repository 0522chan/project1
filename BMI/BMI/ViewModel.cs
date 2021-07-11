using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
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

        public double Weight
        {
            get;
            set;
        }

        public double Tall
        {
            get;
            set;
        }

        private string result;
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
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
