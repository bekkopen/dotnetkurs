using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace PersonPhoneApp
{
    public partial class MainPage : PhoneApplicationPage
    {        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
            personList.SelectionChanged += personList_SelectionChanged;
        }

        public static Person SelectedPerson { get; set; }

        private void personList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var person = personList.SelectedItem as Person;
            if(person != null)
            {
                SelectedPerson = person;
                var uri = new Uri("/Details.xaml", UriKind.Relative);
                NavigationService.Navigate(uri);
            }
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new PersonsRestClient();
            client.GetPersons(result => 
                Deployment.Current.Dispatcher.BeginInvoke(() => 
                    personList.ItemsSource = result));
        }

        private static Person[] LagPersoner()
        {
            var personer = new[] {
                new Person { Name="Patric Bateman", Age=27, HairColor="Brun", Height=184, Gender="M"},
                new Person { Name="Mystique", Age=127, HairColor="Rød", Height=177, Gender="K"},
                new Person { Name="Two Face", Age=58, HairColor="Brun", Height=183, Gender="M"},
                new Person { Name="Cruella De Vil", Age=65, HairColor="Svart og hvitt", Height=168, Gender="K"},
                new Person { Name="Orochimaru", Age=100, HairColor="Svart", Height=180, Gender="M"},
                new Person { Name="Harvey Dent", Age=56, HairColor="Brun", Height=183, Gender="M"},
                new Person { Name="KongenDin", Age=75, HairColor="Ukjent", Height=150, Gender="M"}
            };
            return personer;
        } 
    }
}