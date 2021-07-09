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

//뷰 모델의 역할은 뷰가 사용할 메서드와 필드를 구현하고, 뷰에게 상태 변화를 알리는 것입니다. 
//(뷰는 뷰 모델의 상태 변화를 옵저빙한다,뷰를 참조하면 안되지만 뷰에 크게 의존,
//하나의 뷰에 대한 메소드로 속성 및 액션을 사용하여 데이터를 노출) 
//모델은 비즈니스 로직과 유효성 검사와 데이터를 포함하는 앱의 도메인 모델로 생각할 수 있습니다. 
//

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
