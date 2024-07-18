using DataBase;
using Models;
using System.Diagnostics;

namespace pharmacy.Pages;

public partial class Sales : ContentPage
{
	Entity oEntity = new Entity();
	
	public Sales()
	{
		InitializeComponent();
	}
    private void Add_Clicked(object sender, EventArgs e)
    {
        #region Sales
        SalesModels oSalesMdels = new SalesModels();
        Entity oEntity = new Entity();
        oSalesMdels.SAlesName = SName.Text;
        decimal salary;
        int Quantity;
        if (decimal.TryParse(SPrice.Text, out salary))
        {
            oSalesMdels.Salary = salary;
        }
        if (int.TryParse(Que.Text, out Quantity))
        {
            oSalesMdels.SAlesQuantity = Quantity;
        }
        oEntity.AddSales(oSalesMdels);
        DisplayAlert("Success!", "Done", "Ok");
        this.GetAllDs.ItemsSource = this.oEntity.GetAllSales(); 
       ; 
        #endregion

        /// if user Add Product to sale it 
        /// this will add it in stoke
        #region Stoke
        StokeModel oStokeModel = new StokeModel();
        oStokeModel.sName = SName.Text;
        oStokeModel.SQuantity = Quantity;
        oEntity.AddStoke(oStokeModel); 
        #endregion


        // Customer
        #region Customer
        Cstomer oCstomer = new Cstomer();
        oCstomer.CustomerName = CustomerName.Text;
        int Phone;
        if (int.TryParse(CustomerPhone.Text, out Phone))
        {
            oCstomer.CustomerPhone = Phone;
        }
        int iD;
        if(int.TryParse(CustomerID.Text, out iD))
        {
            oCstomer.CustomerID = iD;
        }
        oEntity.AddCstomer(oCstomer); 
        #endregion

       
    }

    private void GetData_Clicked(object sender, EventArgs e)
    {

        GetAllDs.ItemsSource = oEntity.GetAllSales();
    }
    private async void grad_Clicked_1(object sender, EventArgs e)
    {
        ClsGard oClsGard = new ClsGard();
        string sum = oClsGard.GetSum().ToString();
        await DisplayAlert("",$"{sum}","Ok");
    }
}