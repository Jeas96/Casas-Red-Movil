using Casas_Red_Movil.Views.Corretaje;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Casas_Red_Movil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private async void OnClick()
        {
            if (LogUser(user.Text, pass.Text))
            {
                await Navigation.PushAsync(new MainCorretaje());
            }
        }

        private bool LogUser(string user, string pass)
        {
            return true;
        }
	}
}