
using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class Stock : ContentPage
{
	public Stock()
	{
		InitializeComponent();
	}

    private void Add_Clicked(object sender, EventArgs e)
    {
		Entity oEntity = new Entity();
        StokeModel oStokeModel = new StokeModel();
		oStokeModel.sName = Name.Text;
		if(int.TryParse(Quantity.Text , out int  quantity))
		{
			oStokeModel.SQuantity = quantity;
		}
        DisplayAlert("Success", "Done!", "OK");
        oEntity.AddStoke(oStokeModel);
        GetAllDs.ItemsSource = oEntity.GetAllStoke();

    }

    private void Get_Clicked(object sender, EventArgs e)
    {
        Entity oEntity = new Entity();
        GetAllDs.ItemsSource = oEntity.GetAllStoke();
    }
}