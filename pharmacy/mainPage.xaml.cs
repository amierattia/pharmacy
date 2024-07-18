using DataBase;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using pharmacy.Pages;

namespace pharmacy;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Returns());

    }

    private async void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Stock());

    }

    private async void TapGestureRecognizer_Tapped_4(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Sales());
    }

    private async void TapGestureRecognizer_Tapped_5(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Orders());
    }

    private void OnTextChanged(object sender, TappedEventArgs e)
    {
        Entity oEntity = new Entity();
        SearchBar searchBar = (SearchBar)sender;
        //searchResults.ItemsSource = oEntity.Search(searchBar.Text);

    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Store());
    }

    private async void About_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new About());
    }

  
}