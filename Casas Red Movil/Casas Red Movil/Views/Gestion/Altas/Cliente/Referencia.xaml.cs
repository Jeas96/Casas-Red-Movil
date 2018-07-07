using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion.Altas.Cliente
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Referencia : ContentPage
	{
		public Referencia ()
		{
            BindingContext = new ReferenciaVM();
			InitializeComponent ();
		}
	}
}