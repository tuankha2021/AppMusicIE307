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
    public partial class LichSu : ContentPage
    {
        public ObservableCollection<LichSuSong> LichSuSongs { get; set; }

        public class LichSuSong
        {
            public string songName { get; set; }
            public string songImg { get; set; }
            public string songSinger { get; set; }
            public string songTime { get; set; }
        }
        public LichSu()
        {
            InitializeComponent();
            LichSuSongs = new ObservableCollection<LichSuSong>
            {
                new LichSuSong
                {
                    songImg = "lsbt.jpg",
                    songName = "Làm Sao Buông Tay",
                    songSinger = "The Men",
                    songTime = "12/12/2021"
                },
                new LichSuSong
                {
                    songImg = "plsd.jpg",
                    songName = "Phải Làm Sao Đây",
                    songSinger = "Du Thiên",
                    songTime = "13/12/2021"
                },
                new LichSuSong
                {
                    songImg = "nla.jpg",
                    songName = "Nếu Là Anh",
                    songSinger = "The Men",
                    songTime = "15/12/2021"
                },
                new LichSuSong
                {
                    songImg = "lsbt.jpg",
                    songName = "Làm Sao Buông Tay",
                    songSinger = "The Men",
                    songTime = "21/12/2021"
                },
                new LichSuSong
                {
                    songImg = "kemduyen.jpg",
                    songName = "Kém Duyên",
                    songSinger = "RUM",
                    songTime = "23/12/2021"
                },
            };
            BindingContext = this;
        }
    }
}