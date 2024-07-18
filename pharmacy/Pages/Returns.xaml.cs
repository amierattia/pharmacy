using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class Returns : ContentPage
{
	public Returns()
	{
		InitializeComponent();
	}

    private void Add_Clicked(object sender, EventArgs e)
    {
        Entity oEntity = new Entity();
        returnesModels oClsModels = new returnesModels();
        oClsModels.RName = Name.Text;

        if (oClsModels.RName != null )
		{
            oEntity.Addreturn(oClsModels);
            DisplayAlert("Success", $"Done!", "OK");

        }
        else
        {
            DisplayAlert("Success", "Invalid Data", "OK");

        }
        if(int.TryParse(Qu.Text, out int Quantity))
        {
            oClsModels.RQuantity = Quantity;
        }
        else
        {
            DisplayAlert("Success", "Invalid Data", "OK");

        }

    }
}