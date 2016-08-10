using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RememberMe.Pages
{
    public partial class MainPage : ContentPage
    {

        private TapGestureRecognizer CollectRecognizer = new TapGestureRecognizer();
        private TapGestureRecognizer SearchRecognizer = new TapGestureRecognizer();
        private TapGestureRecognizer ReminderRecognizer = new TapGestureRecognizer();

        public MainPage()
        {
            InitializeComponent();

            CollectRecognizer.Tapped += CollectRecognizer_Tapped;
            Collect.GestureRecognizers.Add(CollectRecognizer);

            SearchRecognizer.Tapped += SearchRecognizer_Tapped;
            Search.GestureRecognizers.Add(SearchRecognizer);

            ReminderRecognizer.Tapped += ReminderRecognizer_Tapped;
            Reminder.GestureRecognizers.Add(ReminderRecognizer);
        }

        private void ReminderRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.Navigation.PushAsync(new ReminderPage());
        }

        private void SearchRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.Navigation.PushAsync(new SearchPage());
        }

        private void CollectRecognizer_Tapped(object sender, EventArgs e)
        {
          PopupNavigation.PushAsync(new RegisterPage()); 
        }
    }
}
