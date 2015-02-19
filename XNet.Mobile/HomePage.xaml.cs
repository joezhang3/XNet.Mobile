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
			NavigationPage.SetHasNavigationBar (this, false);
		}

		protected void SearchActivity(string keyword){
			ActivityList al = new ActivityList (keyword){Title="Activities"};
			Navigation.PushAsync (al);
		}

		void OnSearchBarButtonPressed(object sender, EventArgs args)
		{
			// Get the search text.
			SearchBar searchBar = (SearchBar)sender;
			string searchText = searchBar.Text;
			SearchActivity (searchText);

		}

		void btnViewActivity_Clicked(object sender, EventArgs e)
		{
			SearchActivity (string.Empty);
		}
	}
}

