﻿using System.ComponentModel;
using Xamarin.Forms;
using XamarinBugs.ViewModels;

namespace XamarinBugs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ((ViewModelLocator)this.BindingContext).MainPage.RefreshData();
        }
    }
}
