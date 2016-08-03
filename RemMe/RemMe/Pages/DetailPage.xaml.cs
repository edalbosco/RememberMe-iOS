using RememberMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RememberMe.Pages
{
    public partial class DetailPage : ContentPage
    {

        public DetailPage(Item item)
        {
            InitializeComponent();

            BindingContext = item;
        }
    }
}
