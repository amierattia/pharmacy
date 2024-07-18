using DataBase;
using Models;
using System.Collections.ObjectModel; // Import ObservableCollection

namespace pharmacy.Pages
{
    public partial class Orders : ContentPage
    {
        public Entity oEntity { get; set; }
        public ObservableCollection<ClsModel> OrdersList { get; set; } // Binding property

        public Orders()
        {
            InitializeComponent();
            this.oEntity = new Entity();
            this.OrdersList = new ObservableCollection<ClsModel>();
            BindingContext = this; // Set the binding context
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            ClsModel oClsModel = new ClsModel();

            oClsModel.Productname = OrderName.Text;
            if (int.TryParse(OrderQuantity.Text, out int quantity))
            {
                oClsModel.Quantity = quantity;
            }
            if (oClsModel != null)
            {
                oEntity.Add(oClsModel);
            }
            else
            {
                DisplayAlert("Error!", "you can not add empty data", "Ok");
            }


            this.GetAllDs.ItemsSource = this.oEntity.GetAll();
        }

        private void Get_Clicked(object sender, EventArgs e)
        {
            this.GetAllDs.ItemsSource = this.oEntity.GetAll();
        }

        private async void Control_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderControl());
        }

       

       
    }
}
