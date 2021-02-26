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
                _browser = browserType switch
                {
                    "firefox" => await _pw.Firefox.LaunchAsync(headless: true),
                    "webkit" => await _pw.Webkit.LaunchAsync(headless: true),
                    "chromium" => await _pw.Chromium.LaunchAsync(headless: true),
                    _ => null
                };
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
