using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PizzaDeliveryApp
{
    public partial class CartContentPage : ContentPage
    {
        

        public CartContentPage()
        {
            InitializeComponent();

        }
        
        private async void OnCheckoutButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Checkout", "Checkout process initiated.", "OK");
        }
    }

}
