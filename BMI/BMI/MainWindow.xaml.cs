using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//<<<권장하는 단계>>>
//1.ViewModel을 생성한다.
//2.ViewModel이 노출해야 하는 속성을 찾는다.
//3.알림 속성을 코딩한다.
//4.ViewModel을 View의 DataContext로 사용한다.
//5.View를 ViewModel에 데이터 바인딩한다.
//6.기능적 논리를 코딩한다.(3단계 이후에 언제든지 수행 가능)

namespace BMI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
