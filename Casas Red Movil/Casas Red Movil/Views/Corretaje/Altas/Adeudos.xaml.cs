using Casas_Red_Movil.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje.Altas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adeudos : ContentPage
    {
        public Adeudos()
        {
            BindingContext = new AdeudosVM();
            InitializeComponent();
        }

        private async void OnSave()
        {
            await DisplayAlert("Atencion","Datos Guardados Correctamente","Ok");
        }
	}
}