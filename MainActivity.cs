using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.TextField;
using System;

namespace SpritkostenRechner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button berechnenButton = FindViewById<Button>(Resource.Id.berechnenButton);
            berechnenButton.Click += OnButtonClicked;
        }

        public void OnButtonClicked(object sender, EventArgs e)
        {
            try
            {
                // Code zum Speichern der eingegebenen Zahl in einer Variable und Berechnen des Ergebnisses...
                TextInputEditText durchVerbauch = FindViewById<TextInputEditText>(Resource.Id.durchVerbauch);
                double durchVerbauchNum = Convert.ToDouble(durchVerbauch.Text);

                TextInputEditText strecke = FindViewById<TextInputEditText>(Resource.Id.strecke);
                double streckeNum = Convert.ToDouble(strecke.Text);

                TextInputEditText spritKosten = FindViewById<TextInputEditText>(Resource.Id.spritKosten);
                double spritKostenNum = Convert.ToDouble(spritKosten.Text);

                double gesKostenNum = (durchVerbauchNum / 100) * streckeNum * spritKostenNum;

                TextView resultTextView = FindViewById<TextView>(Resource.Id.textView1);
                resultTextView.SetText("Vrauch in Lieter auf 100 Kilometer: " + gesKostenNum.ToString() + "€", TextView.BufferType.Normal);
            }
            catch
            {

            }
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}