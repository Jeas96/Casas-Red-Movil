using Casas_Red_Movil.Models;
using Casas_Red_Movil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Verificacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainVerificacion : ContentPage
	{
		public MainVerificacion ()
		{
            BindingContext = new MainVerificacionVM();
			InitializeComponent ();
		}

        private async void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var casa = (CasaEnVenta)e.SelectedItem;
            await Navigation.PushAsync(new Verificacion.VerificacionCliente());
        }
    }
}