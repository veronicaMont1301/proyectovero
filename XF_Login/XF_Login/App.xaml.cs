using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using XF_Login.NewFolder;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           // LoginPage = new XF_Login.LoginPage();
           MainPage = new MainPage();
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
