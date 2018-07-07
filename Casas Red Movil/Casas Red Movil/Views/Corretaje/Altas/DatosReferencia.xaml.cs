using Casas_Red_Movil.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje.Altas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatosReferencia : ContentPage
	{
		public DatosReferencia ()
		{
            BindingContext = new DatosReferenciaVM();
			InitializeComponent ();
		}
	}
}