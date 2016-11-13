using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using UXDivers.Artina.Player.Droid;

namespace UXDivers.Gorilla.Droid
{
	[Activity (Label = "Gorilla Player", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (Player.CreateApplication(ApplicationContext, new Config("Gorilla on Asadullah")));
		}

		public override bool OnKeyUp (Keycode keyCode, KeyEvent e)
		{
			if ((keyCode == Keycode.Menu || keyCode == Keycode.F1) && Coordinator.Instance != null) {
				Coordinator.Instance.RequestStatusUpdate ();
				return true; 
			}

			return base.OnKeyUp (keyCode, e); 
		} 
	}
}

