using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace TestAndroid.Views.Activitis
{
    [Activity(Label = "OfferActivity", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class OfferActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_offer);
            TextView tvOffer = FindViewById<TextView>(Resource.Id.tv_offer);
            tvOffer.Text = Intent.GetStringExtra(MainActivity.SER_OBJECT);
        }
    }
}