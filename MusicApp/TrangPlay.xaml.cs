﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrangPlay : ContentPage
    {
        public TrangPlay()
        {
            InitializeComponent();
        }

        private void plus_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CaNhan());
        }
    }
}