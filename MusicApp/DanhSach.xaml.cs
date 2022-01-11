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
    public partial class DanhSach : ContentPage
    {
        public ObservableCollection<ListSong> ListSongs { get; set; }


        public class ListSong
        {
            public string lstimg { get; set; }
            public string lstname { get; set; }
            public string lstimg1 { get; set; }
            public string lstname1 { get; set; }
        }
        public DanhSach()
        {
            InitializeComponent();
            ListSongs = new ObservableCollection<ListSong>
            {
                new ListSong()
                {
                    lstimg = "kemduyen.jpg",
                    lstname = "Kém Duyên",
                    lstimg1 = "dladm.jpg",
                    lstname1 = "Đừng Lo Anh Đợi Mà",
                },
                new ListSong()
                {
                    lstimg = "necd.jpg",
                    lstname = "Người Em Cố Đô",
                    lstimg1 = "plsd.jpg",
                    lstname1 = "Phải Làm Sao Đây"
                },
                new ListSong()
                {
                    lstimg = "hntb.jpg",
                    lstname = "Hôm Nay Tôi Buồn",
                    lstimg1 = "snstd.jpg",
                    lstname1 = "Sai Người Sai Thời Điểm"
                },
                new ListSong()
                {
                    lstimg = "thattinh.jpg",
                    lstname = "Thất Tình",
                    lstimg1 = "nkple.jpg",
                    lstname1 = "Nếu Không Phải Là Em"
                }
            };
            BindingContext = this;
        }
    }
}