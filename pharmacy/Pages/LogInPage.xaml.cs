using DataBase;
using Models;

namespace pharmacy.Pages;

public partial class LogInPage : ContentPage
{
    Entity oEn = new Entity();
    UsersDb oUsersDb = new UsersDb();
    string _User;
    public LogInPage()
    {
        InitializeComponent();
    }

    private async void Create_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreatAccount());
    }

    private async void LogIn_Clicked(object sender, EventArgs e)
    {
        looding.IsRunning = true;
        _User = User.Text;
        string _Pass = Pass.Text;
        bool userFound = false;

        foreach (var user in oEn.GetAllUser())
        {
            if (_User == user.username && _Pass == user.PassWord)
            {
                userFound = true;
                break;
            }
        }

        if (userFound)
        {
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Error", "Invalid User Name or Password", "Ok");
        }
        looding.IsRunning = false;
    }

}