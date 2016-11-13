using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

using Foundation;
using UIKit;

[assembly: ExportRenderer(typeof(Page), typeof(UXDivers.Gorilla.ShakeDetectionRenderer))]
namespace UXDivers.Gorilla.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (Player.CreateApplication(new Config("Gorilla on Asadullah")));

			return base.FinishedLaunching (app, options);
		}

		public override void DidEnterBackground (UIApplication uiApplication)
		{
			base.DidEnterBackground (uiApplication);
		}
	}
}

