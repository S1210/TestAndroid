using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using TestAndroid.Adapters;
using TestAndroid.Contractors;
using TestAndroid.Presenters;
using TestAndroid.Views.Activitis;

namespace TestAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, MainContractor.View
    {
        public const string SER_OBJECT = "serObject";
        private MainContractor.Presenter mPresenter;
        private RecyclerView rvMain;
        private ProgressBar pbMain;
        private const string URL = "https://yastatic.net/market-export/_/partner/help/YML.xml";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            mPresenter = new MainPresenter(this);
            InitRV();
            pbMain = FindViewById<ProgressBar>(Resource.Id.pb_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }

        private void InitRV()
        {
            rvMain = FindViewById<RecyclerView>(Resource.Id.rvMain);
            LinearLayoutManager layoutManager = new LinearLayoutManager(this);
            rvMain.SetLayoutManager(layoutManager);
            mPresenter.GetOffers(URL);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void SetAdapter(RecyclerViewMainAdapter adapter)
        {
            rvMain.SetAdapter(adapter);
        }

        public void OpenIntent(string serObject)
        {
            Intent intent = new Intent(this, typeof(OfferActivity));
            intent.PutExtra(SER_OBJECT, serObject);
            StartActivity(intent);
        }

        public void HidePB()
        {
            pbMain.Visibility = ViewStates.Gone;
        }

        public void ShowSnackbar(string message)
        {
            Toast.MakeText(this, message, Android.Support.Design.Widget.Snackbar.LengthLong).Show();
        }
    }
}
