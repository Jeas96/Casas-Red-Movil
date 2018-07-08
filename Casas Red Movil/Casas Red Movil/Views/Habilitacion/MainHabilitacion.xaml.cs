using Casas_Red_Movil.Models;
using Casas_Red_Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Habilitacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainHabilitacion : ContentPage
    {
        public MainHabilitacion()
        {
            BindingContext = new MainHabilitacionVM();
            InitializeComponent();
        }
        private async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var casa = (CasaEnVenta)e.SelectedItem;
            await Navigation.PushAsync(new Alta.Habilitacion());
        }
    }
}