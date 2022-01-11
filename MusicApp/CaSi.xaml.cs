using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaSi : ContentPage
    {
        public ObservableCollection<SingerVNInfo> SingerVNInfos{ get; set; }


        public class SingerVNInfo
        {
            public string singerImg { get; set; }
            public string singerName { get; set; }
            public string singerAbout { get; set; }
            public string singerSongImg1 { get; set; }
            public string singerSongImg2 { get; set; }
            public string singerSongImg3 { get; set; }
            public string singerSongImg4 { get; set; }
            public string singerSongName1 { get; set; }
            public string singerSongName2 { get; set; }
            public string singerSongName3 { get; set; }
            public string singerSongName4 { get; set; }
        }
        public CaSi()
        {
            InitializeComponent();
            SingerVNInfos = new ObservableCollection<SingerVNInfo>
            {
                new SingerVNInfo()
                {
                  singerImg = "lsdqe.jpg",
                  singerName ="Du Thiên",
                  singerAbout = "Sinh 22/06/1985, quê ở Hải Dương. Là một ca sĩ trẻ tuổi nhưng rất đa tài, anh có thể hát tốt ở các dòng nhạc " +
                  "(nhạc nhẹ, nhạc trữ tình)",
                  singerSongImg1 = "lsdqe.jpg",
                  singerSongImg2 = "dss.jpg",
                  singerSongImg3 = "plsd.jpg",
                  singerSongImg4 = "lecay.jpg",
                  singerSongName1 = "Làm Sao Để Quên Em",
                  singerSongName2 = "Đường Song Song",
                  singerSongName3 = "Phải Làm Sao Đây",
                  singerSongName4 = "Lệ Cay 2 Remix"

                },
                new SingerVNInfo()
                {
                    singerImg = "themen.jpg",
                    singerName = "The Men",
                    singerAbout = "Thành lập năm 2008, gồm 2 thành viên là Lê Hoàng[1], cựu thành viên của nhóm B.O.M[2], và Ngô Tiến Dũng",
                    singerSongImg1 = "nkple.jpg",
                    singerSongImg2 = "lsbt.jpg",
                    singerSongImg3 = "nla.jpg",
                    singerSongImg4 = "cetd.jpg",
                    singerSongName1 ="Nếu Không Phải Là Em",
                    singerSongName2 = "Làm Sao Buông Tay",
                    singerSongName3 = "Nếu Là Anh",
                    singerSongName4 = "Chờ Em Trong Đêm"
                },
                new SingerVNInfo()
                {
                    singerImg = "rum.jpg", 
                    singerName = "RUM",
                    singerAbout = "Rum tên thật là Hồ Minh Triết được khán giả biết đến qua những bản Mashup (Kết hợp nhiều bài hát tạo thành bài hát hoàn chỉnh)",
                    singerSongImg1 = "kemduyen.jpg",
                    singerSongImg2 = "tn.jpg",
                    singerSongImg3 = "otnn.jpg",
                    singerSongImg4 = "ntgm.jpg",
                    singerSongName1 = "Kém Duyên",
                    singerSongName2 = "Tình Nhòa",
                    singerSongName3 = "Ôm Trọn Nỗi Nhớ",
                    singerSongName4 = "Người Theo Gió Mây"
                }
            };
            BindingContext = this;
        }
    }
}