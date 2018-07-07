
using Casas_Red_Movil.ViewModels.Gestion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion.Check
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Check : ContentPage
	{
		public Check ()
		{
            BindingContext = new CheckVM();
			InitializeComponent ();
		}
	}
}