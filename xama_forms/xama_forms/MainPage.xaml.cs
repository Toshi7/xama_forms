﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xama_forms
{
    public partial class MainPage : ContentPage
    {
        void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
        }
        void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }
        void Go_Clicked(object sender, System.EventArgs e)
        {
            Browser.Source = url.Text;
        }
        void Forward_Clicked(object sender, System.EventArgs e)
        {
            if (Browser.CanGoForward)
                Browser.GoForward();
        }
        void Back_Clicked(object sender, System.EventArgs e)
        {
            if (Browser.CanGoBack)
                Browser.GoBack();
        }
        public MainPage()
        {
            InitializeComponent();
            url.Text = "https://www.yahoo.com/";
            Browser.Source = url.Text;
        }
    }
}
