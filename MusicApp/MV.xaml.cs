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
    public partial class MV : ContentPage
    {
        public class MVtop
        {
            public string MVimg { get; set; }
            public string MVava { get; set; }
            public string MVname { get; set; }
        }
        public class MVnew
        {
            public string MVimg { get; set; }
            public string MVava { get; set; }
            public string MVname { get; set; }
        }
        public class MVcontent
        {
            public string MVimg { get; set; }
            public string MVname { get; set; }
        }
        private ObservableCollection<MVtop> mVtops;
        public ObservableCollection<MVtop> MVtops { 
            get
            {
                return mVtops;
            }
            set
            {
                mVtops = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<MVnew> mVnews;
        public ObservableCollection<MVnew> MVnews {
            get
            {
                return mVnews;
            }
            set
            {
                mVnews = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<MVcontent> mVcontents;
        public ObservableCollection<MVcontent> MVcontents {
            get
            {
                return mVcontents;
            }
            set
            {
                mVcontents = value;
                OnPropertyChanged();
            }
        }
        public MV()
        {
            InitializeComponent();
            BindingContext = this;
            MVtops = new ObservableCollection<MVtop>
            {
                new MVtop
                {
                    MVimg = "mvtop1.jpg",
                    MVava = "mvtop1ava.jpg",
                    MVname = "Mang Tiền Về Cho Mẹ"
                },
                new MVtop
                {
                    MVimg = "mvtop2.jpg",
                    MVava ="mvtop2ava.jpg",
                    MVname = "Đom Đóm"
                },
                 new MVtop
                {
                    MVimg = "mvtop3.jpg",
                    MVava ="mvtop3ava.jpg",
                    MVname = "Anh Mệt Rồi"
                },
                  new MVtop
                {
                    MVimg = "mvtop4.jpg",
                    MVava ="mvtop4ava.jpg",
                    MVname = "Sai Người Sai Thời Điểm"
                },
            };
            MVnews = new ObservableCollection<MVnew>
            {
                new MVnew
                {
                    MVimg = "mvnew1.jpg",
                    MVava = "mvtop2ava.jpg",
                    MVname = "Em Gì Ơi"
                },
                new MVnew
                {
                    MVimg = "mvnew2.jpg",
                    MVava =  "mvnewava2.jpg",
                    MVname = "EM Ơi Lên Phố"
                },
                new MVnew
                {
                    MVimg = "mvnew3.jpg",
                    MVava =  "mvnewava3.jpg",
                    MVname = "Thất tình"
                },
                new MVnew
                {
                    MVimg = "mvnew3.jpg",
                    MVava =  "mvnewava3.jpg",
                    MVname = "Buồn Lắm Em Ơi"
                },
            };
            MVcontents = new ObservableCollection<MVcontent>
            {
                new MVcontent
                {
                    MVimg = "mv1.jpg",
                    MVname = "Túp Lều Vàng"
                },
               new MVcontent
                {
                    MVimg = "mv2.jpg",
                    MVname = "Em Gái Mưa"
                },
               new MVcontent
                {
                    MVimg = "mv3.jpg",
                    MVname = "Mình Anh Nơi Này"
                },
               new MVcontent
                {
                    MVimg = "mv4.jpg",
                    MVname = "Nơi Này Có Anh"
                },
            };
        }
    }
}