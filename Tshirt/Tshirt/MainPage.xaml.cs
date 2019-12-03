using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Tshirt
{
    public partial class MainPage : ContentPage
    {
        public List<Item> Tshirt { get; private set; }
       
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var appitem = new Item();
            BindingContext = appitem;
        }
        async void OnSaveClicked(object sender, EventArgs e)
            
        {

            var client = new HttpClient(new HttpClientHandler());
            var url = "http://10.0.2.2:5000/Tshirt";
            var info = App.Database;
            Tshirt = await info.GetItemsAsync();
            var json = JsonConvert.SerializeObject(Tshirt);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            await DisplayAlert("Response Message", response.ReasonPhrase, "Ok");


            var Item = (Item)BindingContext;
            await App.Database.SaveItemAsync(Item);


            await Navigation.PopAsync();
        }
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();


        }
    }
}