using Casas_Red_Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Contaduria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainContaduria : ContentPage
	{
		public MainContaduria ()
		{
            BindingContext = new MainContaduriaVM();
			InitializeComponent ();
		}

        private async void Save()
        {
            await DisplayAlert("Atencion","Datos Guardados con Exito","Ok");
        }
	}
}