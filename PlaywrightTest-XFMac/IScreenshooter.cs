using System;
using System.Threading.Tasks;

namespace PlaywrightTestXFMac
{
    public interface IScreenshooter
    {
        Task<byte[]> GetScreenshot(string url, string browserType = "chromium");
    }
}
