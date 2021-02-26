using System;
using System.Threading.Tasks;
using PlaywrightSharp;

namespace PlaywrightTestXFMac.macOS
{
    public class MacOSShooter : IScreenshooter
    {
        IPage _page;
        IBrowser _browser;
        IPlaywright _pw;

        public async Task<byte[]> GetScreenshot(string url, string browserType = "chromium")
        {
            if(_pw == null)
            {
                await Playwright.InstallAsync();
                _pw = await Playwright.CreateAsync();
            }
            if(_browser == null)
            {
                switch(browserType)
                {
                    case "firefox":
                       _browser = await _pw.Firefox.LaunchAsync(headless: true);
                    break;
                    case "webkit":
                        _browser = await _pw.Webkit.LaunchAsync(headless: true);
                        break;
                    case "chromium":
                        _browser = await _pw.Webkit.LaunchAsync(headless: true);
                        break;
                    default:
                        _browser = null;
                        break;
                }
            }
            if(_page == null)
            {
                _page = await _browser.NewPageAsync();
            }
            await _page.GoToAsync(url, LifecycleEvent.DOMContentLoaded);
            var snapshot = await _page.ScreenshotAsync();
            return snapshot;

            
        }
    }
}
