using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KhamPha : ContentPage
    {
        private ObservableCollection<HotTuan> hotTuans;
        private ObservableCollection<NguocDong> nguocDongs;
        private ObservableCollection<VongQuanh> vongQuanhs;
        public ObservableCollection<HotTuan> HotTuans
        {
            get { return hotTuans; }
            set {hotTuans = value; OnPropertyChanged(); }
        }
        public ObservableCollection<NguocDong> NguocDongs
        {
            get { return nguocDongs; }
            set { nguocDongs = value; OnPropertyChanged(); }
        }
        public ObservableCollection<VongQuanh> VongQuanhs
        {
            get { return vongQuanhs; }
            set { vongQuanhs = value; OnPropertyChanged(); }

        }
        public class HotTuan
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public class NguocDong
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public class VongQuanh
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public KhamPha()
        {
            InitializeComponent();
            BindingContext = this;
            HotTuans = new ObservableCollection<HotTuan> { 
                new HotTuan
                {
                    img = "NN05.jpg",
                    name = "Rainforest"
                },
                new HotTuan
                {
                    img = "NN06.jpg",
                    name = "Không Muốn Yêu Lại Càng Say Đắm"
                },
                new HotTuan
                {
                    img = "NN07.jpg",
                    name = "Người Yêu Giản Đơn"
                },
                new HotTuan
                {
                    img = "NN08.jpg",
                    name = "Người Yêu Giản Đơn"
                },
            };
            NguocDongs = new ObservableCollection<NguocDong> { 
                new NguocDong
                {
                    img = "NG05.jpg",
                    name = "All Too Well"
                },
                new NguocDong
                {
                    img = "NG06.jpg",
                    name = "Drivers License"
                },
                new NguocDong
                {
                    img = "NG07.jpg",
                    name = "Montero(Call Me By Your Name)"
                },
                new NguocDong
                {
                    img = "NG08.jpg",
                    name = "VBS"
                },
            };
            VongQuanhs = new ObservableCollection<VongQuanh>
            {
                new VongQuanh {
                    img = "MN05.jpg",
                    name = "Hoa Nở Không Màu"
                },
                new VongQuanh {
                    img = "MN06.jpg",
                    name = "Hơn Cả Yêu"
                },
                new VongQuanh {
                    img = "MN07.jpg",
                    name = "Big City Boiz"
                },
                new VongQuanh {
                    img = "MN08.jpg",
                    name = "Nàng Thơ"
                },
            };
        }

        private void hottuan_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangPlay());
        }

        private void vongquanh_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangPlay());
        }

        private void ngcdong_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangPlay());
        }
    }
}