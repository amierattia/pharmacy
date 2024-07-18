using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class CreatAccount : ContentPage
{
	public CreatAccount()
	{
		InitializeComponent();
	}

    private void Save_Clicked(object sender, EventArgs e)
    {

		Entity oUserEntity = new Entity();	
		UsersDb db = new UsersDb();
        db.username = UserName.Text;
		db.FName = First_Name.Text;
		db.LName = Last_Name.Text;
        db.PassWord = Pass.Text;
        looding.IsRunning = true;
        oUserEntity.AddUser(db);
        looding.IsRunning = false;
        DisplayAlert("Success", "Done!", "ok");


    }
}