using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace CIDemo.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				.AppBundle ("../../../bin/iPhoneSimulator/Debug/CI-Demo.app")
				.StartApp ();
		}

		[Test]
		public void ViewIsDisplayed ()
		{
//			AppResult[] results = app.WaitForElement (c => c.Child ("UIView"));

			// Tap on navigation bar button
			app.Tap(x=>x.Id("page1Button")); 


			app.Screenshot ("First screen.");

//			Assert.IsTrue (results.Any ());
		}
	}
}


