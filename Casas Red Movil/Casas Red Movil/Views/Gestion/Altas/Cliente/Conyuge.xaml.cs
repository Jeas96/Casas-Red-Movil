﻿
using Casas_Red_Movil.ViewModels.Gestion;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views.Gestion.Altas.Cliente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Conyuge : ContentPage
	{
		public Conyuge ()
		{
            BindingContext = new ConyugeVM();
			InitializeComponent ();
		}
	}
}