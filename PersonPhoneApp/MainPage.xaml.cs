using System;
using System.Windows;
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
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new PersonsRestClient();
            client.GetPersons(result => {
                foreach(var p in result)
                    System.Diagnostics.Debug.WriteLine(p.Name);      
            });
        }
    }
}