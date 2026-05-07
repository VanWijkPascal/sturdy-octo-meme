using QRCoder;

namespace QRCodeGenerator.Utils
{
    public static class QRCodeHelper
    {
        public static void GenerateToFile(string text, string filePath, int pixelsPerModule = 20)
        {
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            using var qrData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrData);

            // Get PNG as byte array
            byte[] pngBytes = qrCode.GetGraphic(pixelsPerModule);

            // Save to file
            File.WriteAllBytes(filePath, pngBytes);
        }
    }
}
