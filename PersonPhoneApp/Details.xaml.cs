using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace PersonPhoneApp
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            DataContext = MainPage.SelectedPerson;
        }
    }
}