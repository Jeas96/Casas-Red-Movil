
using Casas_Red_Movil.ViewModels.Gestion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion.Altas.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conyuge : ContentPage
    {
        public Conyuge()
        {
            BindingContext = new ConyugeVM();
            InitializeComponent();
        }
        private async void Next()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
            await DisplayAlert("Atencion", "Cliente Guardado con Exito", "Ok");
            await Navigation.PushAsync(new MainGestion());
        }
	}
}