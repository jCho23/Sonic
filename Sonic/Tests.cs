using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace Sonic
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("guest_button");
			app.Screenshot("Let's start by Tapping on the 'Guest' Button");

			app.Tap("pay");
			app.Screenshot("We Tapped on the 'Pay' Icon");
			app.Tap("Later");
			app.Screenshot("Then, we Tapped on the 'Later' Button");

			app.Tap("gifts");
			app.Screenshot("Next, we Tapped on the 'Gifts' Icon");
			app.Tap("Later");
			app.Screenshot("Then, we Tapped on the 'Later' Button");

			app.Tap("action_more");
			app.Screenshot("We Tapped in the Drop-Down Menu Icon");
			app.Tap("Menu");
			app.Screenshot("Then, we Tapped on 'Menu'");
			Thread.Sleep(30000);

			app.Tap(x => x.Css(".food-category-name.ng-binding").Index(2));
			Thread.Sleep(30000);
			app.Screenshot("We Tapped on the 'Breakfast' Icon");

			app.Tap(x => x.Css(".food-category-name.ng-binding").Index(1));
			Thread.Sleep(30000);
			app.Screenshot("Then, we Tapped on the 'Hot Dog' Icon");

			app.Tap(x => x.Css(".food-category-name.ng-binding").Index(0));
			Thread.Sleep(30000);
			app.Screenshot("Then, we Tapped on the 'Burgers' Icon");

			//app.Back();
			//app.Screenshot("We Tapped the 'Back' Button");

			//app.Back();
			//app.Screenshot("We Tapped the 'Back' Button");

			//app.Tap("Contact Us");
			//app.Screenshot("Then, we Tapped on 'Contact Us'");
		}

	}
}
