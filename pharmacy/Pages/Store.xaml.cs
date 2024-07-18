using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class Store : ContentPage
{
	public Store()
	{
		InitializeComponent();
	}

    private void Add_Clicked(object sender, EventArgs e)
    {
        Entity oEntity = new Entity();
        storeModels OStoreModels = new storeModels();
        string _Name = Name.Text;
        int Quantity;
        if(int.TryParse(Qu.Text, out Quantity))
        {
            OStoreModels.Salary = Quantity;
        }
        if (OStoreModels != null)
        {
            oEntity.AddStore(OStoreModels);
            oEntity.GetAllStore();
        }
        else
            DisplayAlert("Error!" , "invalid data","Ok");
    }

    private void Get_Clicked(object sender, EventArgs e)
    {
        Entity oEntity = new Entity();
        oEntity.GetAllStore();

    }
}