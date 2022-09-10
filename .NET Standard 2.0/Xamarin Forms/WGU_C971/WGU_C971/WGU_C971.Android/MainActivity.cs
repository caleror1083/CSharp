/* 
     C971 Mobile Application Development Using C#
     Robert Calero
     Student ID# 000998416
*/

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace WGU_C971.Droid
    {
        [Activity(Label = "WGU_C971", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
        public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
            {
                protected override void OnCreate(Bundle savedInstanceState)
                    {
                        TabLayoutResource = Resource.Layout.Tabbar;
                        ToolbarResource = Resource.Layout.Toolbar;
                        base.OnCreate(savedInstanceState);
                        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
                        global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
                        LoadApplication(new App());
                    }
        
                public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
                    {
                        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
                        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
                    }
            }
    }