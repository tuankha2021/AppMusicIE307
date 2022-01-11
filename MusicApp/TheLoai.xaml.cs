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
    public partial class TheLoai : ContentPage
    {
        public TheLoai()
        {
            InitializeComponent();
        }

        private void ZoloacdescButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }
        private void ZoloacImagebtn_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new DanhSach());
        }

        private void vpopbutton_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new DanhSach());
        }

        private void vpopimgbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void kpopimgbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void kpopbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void vnimgbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void vnbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void aniimgbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }

        private void anibtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }
    }
}