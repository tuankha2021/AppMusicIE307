/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using MusicApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(MyTabbedPageRenderer))]
namespace MusicApp.Droid
{
    public class MyTabbedPageRenderer : TabbedPageRenderer
    {
        public MyTabbedPageRenderer(Context context) : base(context)
        {

        }

        protected override void SetTabIcon(TabLayout.Tab tab, FileImageSource icon)
        {
            base.SetTabIcon(tab, icon);
            tab.SetCustomView(Resource.Layout.Custom_tab_layou);

            var imageview = tab.CustomView.FindViewById<ImageView>(Resource.Id.icon);

            imageview.SetBackgroundDrawable(tab.Icon);

        }
    }
}*/