using System;
using System.Collections.Generic;
using XNet.DataProvider;
using Xamarin.Forms;

namespace XNet.Mobile
{
	public partial class ActivityList : ContentPage
	{
		public ActivityList () : this(string.Empty)
		{

		}

		public ActivityList (string keyword)
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar (this, false);
			listView.ItemsSource = ActivityProvider.GetActivities(keyword);
			listView.ItemSelected += async (sender, e) => {
				var activity = (Activity)e.SelectedItem;
				await Navigation.PushAsync(new ActivityDetails(activity));
			};
		}

		void OnSearchBarButtonPressed(object sender, EventArgs args)
		{
			// Get the search text.
			SearchBar searchBar = (SearchBar)sender;
			string searchText = searchBar.Text;


		}
	}
}

