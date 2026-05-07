using MyPlaygroundApp.Utils;

namespace QRCodeGenerator.Services
{
    public class QrCodeHelperService
    {
        string url = "https://dev.to";

        string file = @"C:\Users\User\Downloads\devto.png";

        QRCodeHelper.GenerateToFile(url, file);
    }
}
