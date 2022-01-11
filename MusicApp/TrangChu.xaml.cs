using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class TrangChu : ContentPage
    {
        private ObservableCollection<MuonNghe> muonNghes;
        private ObservableCollection<LuaChon> luaChons;
        private ObservableCollection<NgheNhieu> ngheNhieus;
        private ObservableCollection<MVNoi> mVNois;
        private ObservableCollection<CaSiNoi> caSiNois;
        public ObservableCollection<MuonNghe> MuonNghes
        {
            get { return muonNghes; }
            set { muonNghes = value; OnPropertyChanged(); }
        }
        public ObservableCollection<LuaChon> LuaChons
        {
            get { return luaChons; }
            set { luaChons = value; OnPropertyChanged(); }
        }
        public ObservableCollection<NgheNhieu> NgheNhieus
        {
            get { return ngheNhieus; }
            set { ngheNhieus = value; OnPropertyChanged(); }
             
        }
        public ObservableCollection<MVNoi> MVNois
        {
            get { return mVNois; }
            set { mVNois = value; OnPropertyChanged(); }

        }
        public ObservableCollection<CaSiNoi> CaSiNois
        {
            get { return caSiNois; }
            set { caSiNois = value; OnPropertyChanged(); }

        }
        public class MuonNghe { 
            public string img { get; set; }
            public string name { get; set; }
        }
        public class LuaChon
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public class NgheNhieu
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public class MVNoi
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public class CaSiNoi
        {
            public string img { get; set; }
            public string name { get; set; }
        }
        public TrangChu()
        {
            InitializeComponent();
            BindingContext = this;
            MuonNghes = new ObservableCollection<MuonNghe>
           {
               new MuonNghe
               {
                   img = "MN03.jpg",
                   name = "Con Rồng Cháu Tiên"
               },
               new MuonNghe
               {
                   img = "MN04.jpg",
                   name = "Hoa Hải Đường"
               },
               new MuonNghe
               {
                   img = "MN05.jpg",
                   name = "Hoa Nở Không Màu"
               },
               new MuonNghe
               {
                   img = "MN06.jpg",
                   name = "Big City Boi"
               }
           };
            LuaChons = new ObservableCollection<LuaChon>
            {
                new LuaChon
                {
                    img = "NG01.jpg",
                    name = "Gác Lại Âu Lo"
                },
                 new LuaChon
                {
                    img = "NG02.jpg",
                    name = "Em Không Sai Chúng Ta Sai"
                },
                  new LuaChon
                {
                    img = "NG03.jpg",
                    name = "Bông Hoa Đẹp Nhất"
                },
                   new LuaChon
                {
                    img = "NG04.jpg",
                    name = "Essence"
                }
            };
            NgheNhieus = new ObservableCollection<NgheNhieu> {
                new NgheNhieu
                {
                    img = "NN01.jpg",
                    name = "Leave The Door Open"
                },
                new NgheNhieu
                {
                    img = "NN02.jpg",
                    name = "Happier Than Ever"
                },
                new NgheNhieu
                {
                    img = "NN03.jpg",
                    name = "Todo de Ti"
                },
                new NgheNhieu
                {
                    img = "NN04.jpg",
                    name = "I Drink Wine"
                }
            };
            MVNois = new ObservableCollection<MVNoi> {
                new MVNoi
                {
                    img = "MV01.jpg",
                    name = "Mình Là Gì Của Nhau"
                },
                new MVNoi
                {
                    img = "MV02.jpg",
                    name = "Em Yêu Ơi"
                },
                new MVNoi
                {
                    img = "MV03.jpg",
                    name = "Hết Thương Cạn Nhớ"
                },
                new MVNoi
                {
                    img = "MV04.jpg",
                    name = "Quay Lại Lại Yêu"
                }
            };
            CaSiNois = new ObservableCollection<CaSiNoi> { 
                new CaSiNoi
                {
                    img = "mvnewava2.jpg",
                    name = "Minh Vương M4U"
                },
                new CaSiNoi
                {
                    img = "mvnewava3.jpg",
                    name = "Trịnh Đình Quang"
                },
                new CaSiNoi
                {
                    img = "mvtop4ava.jpeg",
                    name = "Thanh Hưng"
                },
                new CaSiNoi
                {
                    img = "plsd.jpg",
                    name = "Du Thiên"
                }
            };
        }

        private void news_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TinTuc());
        }

        private void film_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MV());
        }

        private void mic_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MV());
        }

        private void music_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangChu());
        }
    }

}