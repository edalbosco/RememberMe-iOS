using RememberMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace RememberMe.Pages
{
    public partial class SearchPage : ContentPage
    {

        private string _search;
        private List<Item> _items;

        public SearchPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Search = "";
        }

        public void SearchClicked(object sender, EventArgs e)
        {
            SearchItems();
        }

        public string Search
        {
            get
            {
                return _search;
            }

            set
            {
                _search = value;
                OnPropertyChanged();
            }
        }

        public void SearchItems()
        {
            Items = App.Database.GetItems(Search).ToList();
        }

        public List<Item> Items
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
    }
}
