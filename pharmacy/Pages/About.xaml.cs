using Models;

namespace pharmacy;

public partial class About : ContentPage
{
	List<info> listInfo;
	public About()
	{
		InitializeComponent();
		listInfo = new List<info>()
		{ 
			new info() {Name ="Khalid walid Abd el_halim bedir" , Image="ninja.jpg" },
			new info() {Name ="Khaled Muhammad Rizq Fouda" , Image="ninja.jpg"},
			new info() {Name = "Salem Abdo Salem Al-Shami" , Image="ninja.jpg"},
			new info() {Name ="Hosni Ashraf Hassan Kamal", Image="ninja.jpg"},
			new info() {Name ="Reda Abdul Majeed Sahsah", Image="ninja.jpg"},
		};
		GetAllData.ItemsSource = listInfo;
		BindingContext = this;
	}

   
}