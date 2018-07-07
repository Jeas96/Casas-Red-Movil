using Casas_Red_Movil.ViewModels;
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
	}
}