using System;
using PlaywrightTestXFMac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlaywrightTest_XFMac
{
    public partial class App : Application
    {
        public static IScreenshooter Shooter { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void Init(IScreenshooter shooter)
        {
            App.Shooter = shooter;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
