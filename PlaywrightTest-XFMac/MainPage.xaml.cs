using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlaywrightTest_XFMac
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void goButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(urlEntry.Text)) urlEntry.Text = "https://www.bing.com";
            var image = await App.Shooter.GetScreenshot(urlEntry.Text);

            var imgSource = ImageSource.FromStream(() => new MemoryStream(image));

            browserImage.Source = imgSource;
        }
    }
}
