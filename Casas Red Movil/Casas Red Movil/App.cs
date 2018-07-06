using Casas_Red_Movil.Views;
using Xamarin.Forms;

namespace Casas_Red_Movil
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
