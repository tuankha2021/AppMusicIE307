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
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void theloai_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TheLoai());
        }

        private void MV_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MV());
        }

        private void casi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CaSi());
        }

        private void lichsu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LichSu());
        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogIn());
        }
    }
}