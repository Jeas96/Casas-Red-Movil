using Casas_Red_Movil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Corretaje.Altas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatosVivienda : ContentPage
	{
		public DatosVivienda ()
		{
            BindingContext = new DatosViviendaVM();
			InitializeComponent ();
		}
        private async void OnSave()
        {
            await DisplayAlert("Atencion", "Datos Guardados Correctamente", "Ok");
        }
    }
}