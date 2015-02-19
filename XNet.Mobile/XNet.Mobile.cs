using System;

using Xamarin.Forms;

namespace XNet.Mobile
{
	public class App : Application
	{
		private TabbedPage mainPage;

		public App ()
		{
			// The root page of your application
			mainPage = new TabbedPage ();

			mainPage.Children.Add (new NavigationPage(new HomePage ()){Title = "Home"});
			mainPage.Children.Add (new NavigationPage(new ActivityList ()){Title = "Activity"});
			mainPage.Children.Add (new ActivityList (){Title = "Reservation"});
			mainPage.Children.Add (new ActivityList (){Title = "Membership"});
			mainPage.Children.Add (new ActivityList (){Title = "My Cart"});
			MainPage = mainPage;
		}
		 
		public void NavigateTo(int whichTab){
			mainPage.SelectedItem = whichTab;
		}

		public static void ShowLogin(ContentPage page){
			page.Navigation.PushAsync (new Login ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

