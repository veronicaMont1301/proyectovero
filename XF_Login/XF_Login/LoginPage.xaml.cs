
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.NewFolder;

namespace XF_Login
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage ()
        {
            var vm = new LoginViewModel();

            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            Email.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }

        public LoginViewModel BindingContext { get; }

        private void DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}