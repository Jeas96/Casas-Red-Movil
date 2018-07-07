using Casas_Red_Movil.ViewModels;
using Casas_Red_Movil.Views.Corretaje.Altas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainCorretaje : ContentPage
	{
		public MainCorretaje ()
		{
            BindingContext = new MainCorretajeVM();
			InitializeComponent ();
		}

        private async void NewClient()
        {
            await Navigation.PushAsync(new DatosPersonales());
        }

    }
}