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
    public partial class ReminderRegisterPage : PopupPage
    {
        private string name;
        private string place;

        ReminderPage _parent;

        public ReminderRegisterPage(ReminderPage parent)
        {
            InitializeComponent();
            _parent = parent;
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
            Reminder item = new Reminder() { Name = Name, Time = Place };

            App.Database.SaveReminder(item);

            PopupNavigation.PopAsync();

            _parent.LoadData();
        }
    }
}
