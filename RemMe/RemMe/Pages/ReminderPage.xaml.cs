using RememberMe.Models;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace RememberMe.Pages
{
    public partial class ReminderPage : ContentPage
    {

        private List<Reminder> _reminders;
        private Command addReminderCommand;

        public ReminderPage()
        {
            InitializeComponent();
            AddReminderCommand = new Command(AddReminder);

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadData();
        }

        private void AddReminder(object obj)
        {
            PopupNavigation.PushAsync(new ReminderRegisterPage(this));
        }

        public void OnDeleteItem(object sender, EventArgs e)
        {
            App.Database.DeleteReminder(((sender as BindableObject).BindingContext as Reminder).ID);
            LoadData();
        }

        public void LoadData()
        {
            Reminders = App.Database.GetReminders().ToList();
        }

        public List<Reminder> Reminders
        {
            get
            {
                return _reminders;
            }

            set
            {
                _reminders = value;
                OnPropertyChanged();
            }
        }

        public Command AddReminderCommand
        {
            get
            {
                return addReminderCommand;
            }

            set
            {
                addReminderCommand = value; OnPropertyChanged();
            }
        }
    }
}
