using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logIn_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppShell());
        }

        private void SignUp_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());

        }
    }
}