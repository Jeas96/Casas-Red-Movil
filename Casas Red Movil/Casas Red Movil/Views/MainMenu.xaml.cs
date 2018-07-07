using Casas_Red_Movil.ViewModels;
using Casas_Red_Movil.Views.Contaduria;
using Casas_Red_Movil.Views.Corretaje;
using Casas_Red_Movil.Views.Gestion;
using Casas_Red_Movil.Views.Habilitacion;
using Casas_Red_Movil.Views.Verificacion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
		public MainMenu ()
		{
            BindingContext = new MainMenuVM();
			InitializeComponent ();
		}

        private async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            string opcion = e.SelectedItem.ToString();
            switch (opcion)
            {
                case "Corretaje":
                    await Navigation.PushAsync(new MainCorretaje());
                    break;
                case "Habilitacion":
                    await Navigation.PushAsync(new MainHabilitacion());
                    break;
                case "Gestion":
                    await Navigation.PushAsync(new MainGestion());
                    break;
                case "Verificacion":
                    await Navigation.PushAsync(new MainVerificacion());
                    break;
                case "Contaduria":
                    await Navigation.PushAsync(new MainContaduria());
                    break;
            }
        }
	}
}