using QRCoder;
using System.Drawing;
namespace PhotoDrop2;

public static class QrUtil
{
    public static Bitmap Generate(string text)
    {
        var gen = new QRCodeGenerator();
        var data = gen.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
        var qr = new QRCode(data);
        return qr.GetGraphic(10);
    }
}

