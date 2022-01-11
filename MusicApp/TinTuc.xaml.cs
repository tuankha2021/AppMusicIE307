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
    public partial class TinTuc : ContentPage
    {
        private ObservableCollection<TinTucInfo> tinTucInfos;
        public ObservableCollection<TinTucInfo> TinTucInfos { 
            get { return tinTucInfos; }
            set 
            { 
                tinTucInfos = value; 
                OnPropertyChanged(); 
            }
        }

        private ObservableCollection<Event> events;
        public ObservableCollection<Event> Events {
            get { return events; }
            set
            {
                events = value;
                OnPropertyChanged();
            }
        }

        public class TinTucInfo { 
            public string avaUser { get; set; }
            public string upPerson { get; set; }
            public string timeUp { get; set; }
            public string content { get; set; }
        }
        public class Event
        {
            public string eventImg { get; set; }
        }

        public TinTuc()
        {
            InitializeComponent();
            BindingContext = this;
            TinTucInfos = new ObservableCollection<TinTucInfo> {
                new TinTucInfo
                {
                    avaUser = "ava1.jpg",
                    upPerson = "Nguyễn Ngọc Huy",
                    timeUp = "10/11/2021",
                    content = "Ban tổ chức Grammy đã chính thức đưa ra thông báo về lễ trao giải lần thứ 64. " +
                    "Theo đó, lễ trao giải Grammy 2022 sẽ bị hoãn vô thời hạn do sự lây lan trên diện rộng của biến thể mới Omicron."
                },
                new TinTucInfo
                {
                    avaUser = "av2.jpg",
                    upPerson = "Nguyễn Tuấn Kha",
                    timeUp = "25/11/2021",
                    content = "BTS đã chính thức trở thành nghệ sĩ ngoại quốc đầu tiên trong lịch sử đứng đầu BXH Nghệ sĩ thường niên của Oricon (Nhật Bản)."
                },
                new TinTucInfo
                {
                    avaUser = "av3.jpg",
                    upPerson = "Trần Thị Thùy Anh",
                    timeUp = "23/12/2021",
                    content = "Bản hit 'Shape of You' của nam ca sĩ Ed Sheeran đã chính thức chạm cột mốc 3 tỷ lượt nghe trên nền tảng Spotify."
                }
            };
            Events = new ObservableCollection<Event>
            {
                new Event{eventImg="event1.jpg"},
                new Event{eventImg="event2.jpeg"},
                new Event{eventImg="event3.png"}
            };
        }
    }
}