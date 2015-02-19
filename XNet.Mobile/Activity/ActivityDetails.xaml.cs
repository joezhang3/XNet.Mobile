using System;
using System.Collections.Generic;
using XNet.DataProvider;
using Xamarin.Forms;

namespace XNet.Mobile
{
	public partial class ActivityDetails : ContentPage
	{
		public ActivityDetails ()
		{
			InitializeComponent ();
		}

		public ActivityDetails(Activity activity){
			InitializeComponent ();
			this.BindingContext = activity;
		}

		void btnAdd_Click(object obj, EventArgs e){
			DisplayAlert ("Message", "activity is added to cart", "Ok", "Cancel");
		}
	}
}

