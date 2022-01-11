using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaNhan : ContentPage
    {
        private ObservableCollection<PersonalContent> personalContents;
        private ObservableCollection<PersonalContent_2> personalContent_2s;
        private ObservableCollection<Personal> personals;
        private ObservableCollection<Personal_2> personal_2s;
        public ObservableCollection<Personal> Personals
        {
            get { return personals; }
            set { personals = value; OnPropertyChanged(); }
        }
        public ObservableCollection<Personal_2> Personal_2s
        {
            get { return personal_2s; }
            set { personal_2s = value; OnPropertyChanged(); }
        }
        public ObservableCollection<PersonalContent> PersonalContents
        {
            get { return personalContents; }
            set { personalContents = value;OnPropertyChanged(); }
        }
        public ObservableCollection<PersonalContent_2> PersonalContent_2s
        {
            get { return personalContent_2s; }
            set { personalContent_2s = value; OnPropertyChanged(); }
        }
        public class Personal
        {
            public string image { get; set; }
            public string songName { get; set; }
            public string singer { get; set; }
            public string delButton { get; set; }
        }

        public class Personal_2
        {
            public string image { get; set; }
            public string songName { get; set; }
            public string singer { get; set; }
            public string delButton { get; set; }
        }
        public class PersonalContent {
            public string image { get; set; }
            public string songName { get; set; }
            public string singer { get; set; }
            public string delButton { get; set; }
        }
        public class PersonalContent_2 {
            public string image { get; set; }
            public string songName { get; set; }
            public string singer { get; set; }
            public string delButton { get; set; }
        }
        public CaNhan()
        {
            BindingContext = this;
            InitializeComponent();
            Personals = new ObservableCollection<Personal>
            {
                 new Personal()
                {
                    image = "thattinh.png",
                    songName = "Thất tình",
                    singer = "Trịnh Đình Quang",
                    delButton = "bin.png"
                },
                 new Personal()
                {
                    image = "kemduyen.jpg",
                    songName = "Kém Duyên",
                    singer = "NIT",
                    delButton = "bin.png"
                },
                  new Personal()
                {
                    image = "hntb.jpg",
                    songName = "Hôm Nay Tôi Buồn",
                    singer = "Phùng Khánh Linh",
                    delButton = "bin.png"
                }

            };
            Personal_2s = new ObservableCollection<Personal_2>
            {
                  new Personal_2()
                {
                    image = "necd.jpg",
                    songName = "Người Em Cố Đô",
                    singer = "NUM X Daa",
                    delButton = "bin.png"
                },
                new Personal_2()
                {
                    image = "dladm.jpg",
                    songName = "Đừng Lo Anh Đợi Mà",
                    singer = "Mr Siro",
                    delButton = "bin.png"
                }
            };
            PersonalContents = new ObservableCollection<PersonalContent>
            {
                new PersonalContent
                {
                    image = "mvtop4ava.jpeg",
                    singer = "Thanh Hưng",
                    songName = "Đúng Người Đúng Thời Điểm",
                    delButton = "bin.png"
                },
                new PersonalContent
                {
                    image = "lsdqe.jpg",
                    singer = "Du Thiên",
                    songName = "Làm Sao Để Quên Em",
                    delButton = "bin.png"
                },
                new PersonalContent
                {
                    image = "mvtop3ava.jpg",
                    singer = "Anh Quân Idol",
                    songName = "Anh Mệt Rồi",
                    delButton = "bin.png"
                }
            };
            PersonalContent_2s = new ObservableCollection<PersonalContent_2>
            {
                new PersonalContent_2
                {
                    image = "mvtop2ava.jpg",
                    singer = "Jack",
                    songName = "Đom Đóm",
                    delButton = "bin.png"
                },
                new PersonalContent_2
                {
                    image = "tn.jpg",
                    singer = "RUM",
                    songName = "Tình Nhòa",
                    delButton = "bin.png"
                },
                new PersonalContent_2
                {
                    image = "plsd.jpg",
                    singer = "Du Thiên",
                    songName = "Phải Làm Sao Đây",
                    delButton = "bin.png"
                },
            };
        }

        private void play_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrangPlay());
        }
    }
}