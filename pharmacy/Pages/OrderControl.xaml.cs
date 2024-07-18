using DataBase;
using Models;
using System.Collections.Generic;
namespace pharmacy.Pages;

public partial class OrderControl : ContentPage
{
    public Entity oEntity {  get; set; }
   
    public OrderControl()
	{
		InitializeComponent();
    }

   

    private void Delet_Clicked(object sender, EventArgs e)
    {
        oEntity = new Entity();
        string ID = Id.Text;
        DisplayAlert("Success", $"the ID : {ID} is deleted", "OK");
        oEntity.Delet(ID);
    }

    private void EditeD_Clicked(object sender, EventArgs e)
    {
        Uodate.Content = new orderUpdate();



    }
}