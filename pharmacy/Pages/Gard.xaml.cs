namespace pharmacy.Pages;

public partial class Gard : ContentPage
{
	public Gard()
	{
		InitializeComponent();
		ClsGard oClsGard = new ClsGard();
        string sum =  oClsGard.GetSum().ToString();
		Gardname.Text = sum;
    }
}