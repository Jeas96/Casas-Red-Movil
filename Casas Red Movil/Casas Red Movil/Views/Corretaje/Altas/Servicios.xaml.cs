
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje.Altas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Servicios : ContentPage
	{
		public Servicios ()
		{
			InitializeComponent ();
		}
        private async void OnSave()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
        }
    }
}