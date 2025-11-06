using System;
using Xamarin.Forms;

namespace PizzaDeliveryApp
{
    public partial class PizzaDetailsPage : ContentPage
    {
        public PizzaDetailsPage(string pizzaName, string description, string imageUrl, double price)
        {
            InitializeComponent();

            
            imgPizza.Source = imageUrl;
            lblPizzaName.Text = pizzaName;
            lblDescription.Text = description;
            lblPrice.Text = $"Price: {price:C}";
        }

        private async void OnAddToCartClicked(object sender, EventArgs e)
        {
            // Placeholder action indicating that the pizza was added to the cart
            await DisplayAlert("Added to Cart", "The pizza was added to your cart.", "OK");
        }
    }
}
