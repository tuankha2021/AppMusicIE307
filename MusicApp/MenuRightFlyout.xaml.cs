using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuRightFlyout : ContentPage
    {
        public ListView ListView;

        public MenuRightFlyout()
        {
            InitializeComponent();

            BindingContext = new MenuRightFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MenuRightFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuRightFlyoutMenuItem> MenuItems { get; set; }

            public MenuRightFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MenuRightFlyoutMenuItem>(new[]
                {
                    new MenuRightFlyoutMenuItem { Id = 0, Title = "Trang Chủ", TargetType=typeof(TrangChu) },
                    new MenuRightFlyoutMenuItem { Id = 1, Title = "Cá Nhân",TargetType=typeof(CaNhan) },
                    new MenuRightFlyoutMenuItem { Id = 2, Title = "Khám Phá", TargetType=typeof(KhamPha) },
                    new MenuRightFlyoutMenuItem { Id = 3, Title = "Page 4", },
                    new MenuRightFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}