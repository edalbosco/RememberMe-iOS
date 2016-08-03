using RememberMe.Models;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RememberMe.Pages
{
    public partial class RegisterPage : PopupPage
    {
        private string name;
        private string place;

        public RegisterPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value; OnPropertyChanged();
            }
        }

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value; OnPropertyChanged();
            }
        }

        public void SaveClicked(object sender, EventArgs e)
        {
            Item item = new Item() { Name = Name, Place = Place };

            App.Database.SaveItem(item);

            PopupNavigation.PopAsync();
        }
    }
}
