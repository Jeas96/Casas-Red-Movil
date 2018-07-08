
using Casas_Red_Movil.Models;
using Casas_Red_Movil.ViewModels;
using Casas_Red_Movil.Views.Gestion.Altas.Cliente;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainGestion : ContentPage
	{
		public MainGestion ()
		{
            BindingContext = new MainGestionVM();
			InitializeComponent ();
		}

        private async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var casa = (CasaEnVenta)e.SelectedItem;
            await Navigation.PushAsync(new Check.Check());
        }

        private async void AgregarCliente() { await Navigation.PushAsync(new DatosGenerales()); }
    }
}