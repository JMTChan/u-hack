﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class vieworadd : ContentPage
	{
		public vieworadd ()
		{
			InitializeComponent ();
		}
        public async void toaddproduct(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addproduct());
        }
        public async void toviewsell(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new viewsell());
        }
	}
}