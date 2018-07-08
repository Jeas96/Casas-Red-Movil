using Casas_Red_Movil.ViewModels.Gestion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion.Altas.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Referencia : ContentPage
	{
		public Referencia ()
		{
            BindingContext = new ReferenciaVM();
			InitializeComponent ();
		}

        private async void Next()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
            await Navigation.PushAsync(new Conyuge());
        }
    }
}