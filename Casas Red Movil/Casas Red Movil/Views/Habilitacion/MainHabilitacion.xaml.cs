using Casas_Red_Movil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Habilitacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainHabilitacion : ContentPage
	{
		public MainHabilitacion ()
		{
            BindingContext = new MainHabilitacionVM();
			InitializeComponent ();
		}
	}
}