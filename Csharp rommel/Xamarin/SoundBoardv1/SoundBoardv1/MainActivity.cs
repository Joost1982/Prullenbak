using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Media;
using System;

namespace SoundBoardv1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private MediaPlayer damendenie;
        private MediaPlayer garage;
        private MediaPlayer goedbekeken;
        private MediaPlayer handinbroekje;
        private MediaPlayer jazeittie;
        private MediaPlayer kroeg;
        private MediaPlayer meiske;

        private Button DamendenieButton;
        private Button GarageButton;
        private Button GoedbekekenButton;
        private Button HandinbroekjeButton;
        private Button JazeittieButton;
        private Button KroegButton;
        private Button MeisjeButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

           //Title = "Soundbordje";

            garage = MediaPlayer.Create(this, Resource.Raw.garage);
            GarageButton = FindViewById<Button>(Resource.Id.button1);
            GarageButton.Click += GarageButtonClicked;

            damendenie = MediaPlayer.Create(this, Resource.Raw.daMendeNie);
            DamendenieButton = FindViewById<Button>(Resource.Id.button2);
            DamendenieButton.Click += DamendenieButtonClicked;

            goedbekeken = MediaPlayer.Create(this, Resource.Raw.goedBekeken);
            GoedbekekenButton = FindViewById<Button>(Resource.Id.button3);
            GoedbekekenButton.Click += GoedbekekenButtonClicked;

            handinbroekje = MediaPlayer.Create(this, Resource.Raw.handinBroekje);
            HandinbroekjeButton = FindViewById<Button>(Resource.Id.button4);
            HandinbroekjeButton.Click += HandinbroekjeButtonClicked;

            jazeittie = MediaPlayer.Create(this, Resource.Raw.jaZeittie);
            JazeittieButton = FindViewById<Button>(Resource.Id.button5);
            JazeittieButton.Click += JazeittieButtonClicked;

            kroeg = MediaPlayer.Create(this, Resource.Raw.kroegGeopend);
            KroegButton = FindViewById<Button>(Resource.Id.button6);
            KroegButton.Click += KroegButtonClicked; ;
            
            meiske = MediaPlayer.Create(this, Resource.Raw.liefMeiske);
            MeisjeButton = FindViewById<Button>(Resource.Id.button7);
            MeisjeButton.Click += MeisjeButtonClicked;

        }

        public void GarageButtonClicked(object sender, EventArgs e)
        {
           garage.Start();
        }

        public void DamendenieButtonClicked(object sender, EventArgs e)
        {
           damendenie.Start();
        }

        public void GoedbekekenButtonClicked(object sender, EventArgs e)
        {
           goedbekeken.Start();
        }

        public void HandinbroekjeButtonClicked(object sender, EventArgs e)
        {
           handinbroekje.Start();
        }

        public void JazeittieButtonClicked(object sender, EventArgs e)
       {
           jazeittie.Start();
        }

        public void KroegButtonClicked(object sender, EventArgs e)
        {
           kroeg.Start();
        }

        public void MeisjeButtonClicked(object sender, EventArgs e)
        {
           meiske.Start();
        }
    }
}