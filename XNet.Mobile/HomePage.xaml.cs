using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XNet.DataProvider;

namespace XNet.Mobile
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
			listView.ItemsSource = ActivityProvider.GetActivities();
		}
	}
}

