using System;
using Xamarin.Forms;

namespace Tshirt
{
    public partial class ItemPage : ContentPage
    {
        public int ID { get; internal set; }

        public ItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var item = (Item)BindingContext;
            await App.Database.SaveItemAsync(item);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var item = (Item)BindingContext;
            await App.Database.DeleteItemAsync(item);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var Item = (Item)BindingContext;
            
        }
    }
}
