using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class orderUpdate : ContentView
{
	public orderUpdate()
	{
		InitializeComponent();
	}

    private void EditeD_Clicked(object sender, EventArgs e)
    {
        Entity oEntity = new Entity();
        ClsModel oClsModel = new ClsModel();
        int ID;
        if (int.TryParse(Id.Text, out ID))
        {
            oClsModel.Id = ID;
        }
        oClsModel.Productname = Name.Text;

        decimal _salary;
        if (decimal.TryParse(Salary.Text, out _salary))
        {
            oClsModel.Price = _salary;
        }
        int Quantityy;
        if (int.TryParse(Quantity.Text, out Quantityy))
        {
            oClsModel.Quantity = Quantityy;

        }
        if (oClsModel.Productname != null && _salary != null && Quantityy != null)
        {

            oEntity.Edite(oClsModel);
            Entry _Name = new Entry();
          //  DisplayAlert("Success", "Done!", "ok");
        }
        else
        {
            
          //  DisplayAlert("Error!", "Invalid Data", "ok");
        }
    }
}