﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlMvvm
{
    public partial class NoteDetail : ContentPage
    {
        
        public NoteDetail()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.ReadNote();
            }
            catch { }
        }
        async void button_clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

