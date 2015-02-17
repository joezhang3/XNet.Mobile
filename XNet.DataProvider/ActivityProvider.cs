using System;
using System.Collections.Generic;
namespace XNet.DataProvider
{
	public class ActivityProvider
	{
		public ActivityProvider ()
		{
		}

		public static Activity[] GetActivities(){
			return new Activity[]{
				new Activity(){ Name="First Activity", Id = 1, Price = 20.0, Location = "My Facility" },
				new Activity(){ Name="First Activity 1", Id = 2, Price = 30.0, Location = "My Facility" },
				new Activity(){ Name="First Activity 2", Id = 3, Price = 40.0, Location = "My Facility" },
				new Activity(){ Name="First Activity 3", Id = 4, Price = 50.0, Location = "My Facility" },
			};
		}
	}
}

