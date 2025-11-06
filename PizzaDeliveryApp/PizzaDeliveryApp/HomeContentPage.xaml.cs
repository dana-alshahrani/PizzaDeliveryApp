using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PizzaDeliveryApp
{
    public partial class HomeContentPage : ContentPage
    {
        public Pizza Pizza1 { get; set; }
        public Pizza Pizza2 { get; set; }
        public Pizza Pizza3 { get; set; }
        public Pizza Pizza4 { get; set; }
        public Pizza Pizza5 { get; set; }

        public HomeContentPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            // Initialize the pizzas with dummy data
            Pizza1 = new Pizza
            {
                Name = "Pepperoni Pizza",
                Description = "Indulge in the bold and savory flavors of our Pepperoni pizza. Picture a golden crust generously adorned with zesty tomato sauce, gooey mozzarella cheese, and a generous scattering of spicy pepperoni slices. Each bite is a symphony of smoky, meaty, and slightly spicy notes that will satisfy even the most discerning pizza connoisseur.",
                ImageUrl = "pizza1.jpg",
                Price = 10.99
            };

            Pizza2 = new Pizza
            {
                Name = "Margherita Pizza",
                Description = "Our Margherita pizza is a timeless classic that captures the essence of Italian simplicity. Each bite is a celebration of fresh flavors, with a thin crust topped with tangy tomato sauce, creamy mozzarella cheese, and fragrant basil leaves. It's a perfect harmony of textures and tastes that will transport you straight to the streets of Naples.",
                ImageUrl = "pizza2.jpg",
                Price = 12.99
            };

            Pizza3 = new Pizza
            {
                Name = "Vegetarian Pizza",
                Description = "Our Vegetarian pizza is a vibrant celebration of fresh produce and wholesome ingredients. Enjoy a garden-fresh medley of ripe tomatoes, crisp bell peppers, earthy mushrooms, zesty red onions, and briny black olives, all nestled on a bed of tangy tomato sauce and melted mozzarella cheese. It's a guilt-free pleasure that's bursting with flavor and goodness in every bite.",
                ImageUrl = "pizza3.jpg",
                Price = 14.99
            };

            Pizza4 = new Pizza
            {
                Name = "BBQ Chicken Pizza",
                Description = "Prepare to be amazed by the mouthwatering combination of flavors in our BBQ Chicken pizza. Tender chunks of grilled chicken breast marinated in smoky barbecue sauce, paired with caramelized onions, tangy BBQ sauce, and melted mozzarella cheese atop a crispy crust. It's a sweet and savory delight that strikes the perfect balance between indulgence and satisfaction.",
                ImageUrl = "pizza4.jpg",
                Price = 16.99
            };

            Pizza5 = new Pizza
            {
                Name = "Supreme Pizza",
                Description = "For those who crave variety,our Supreme pizza is the ultimate feast for the senses. Piled high with a colorful assortment of fresh vegetables like bell peppers, onions, mushrooms, and black olives, along with savory Italian sausage and pepperoni, this pizza offers a delightful medley of flavors and textures that will tantalize your taste buds.",
                ImageUrl = "pizza5.jpg",
                Price = 18.99
            };

            BindingContext = this;
        }

        private async void OnProductTapped(object sender, EventArgs e)
        {
            var selectedPizza = (sender as Image)?.BindingContext as Pizza; // Get the selected pizza
            if (selectedPizza != null)
            {
                
                await Navigation.PushAsync(new PizzaDetailsPage(selectedPizza.Name, selectedPizza.Description, selectedPizza.ImageUrl, selectedPizza.Price));
            }
        }

        private async void OnCartButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CartContentPage()); // Navigate to the cart page
        }
    }
}
