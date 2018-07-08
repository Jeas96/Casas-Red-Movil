
using Casas_Red_Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Habilitacion.Alta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Habilitacion : ContentPage
	{
		public Habilitacion ()
		{
            BindingContext = new HabilitacionVM();
			InitializeComponent ();
		}

        private async void OnSave()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
        }
    }
}