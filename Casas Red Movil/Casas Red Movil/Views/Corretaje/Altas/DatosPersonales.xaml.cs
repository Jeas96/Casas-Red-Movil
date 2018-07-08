using Casas_Red_Movil.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje.Altas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatosPersonales : ContentPage
	{
		public DatosPersonales ()
		{
            BindingContext = new DatosPersonalesVM();
			InitializeComponent ();
		}
        private async void OnSave()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
            await Navigation.PushAsync(new DatosVivienda());
        }
    }
}