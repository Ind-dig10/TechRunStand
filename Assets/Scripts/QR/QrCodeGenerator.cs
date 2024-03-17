using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;

public class QRCodeGenerator : MonoBehaviour
{
    public RawImage qrCodeImage;
    public string qrCodeData = "Hello username";

    void Start()
    {
        GenerateQRCode();
    }

    public void GenerateQRCode()
    {
        Texture2D qrCodeTexture = GenerateQRCodeTexture(qrCodeData, 256, 256);
        if (qrCodeTexture != null)
        {
            Debug.Log(123);
            qrCodeImage.texture = qrCodeTexture;
        }
    }

    Texture2D GenerateQRCodeTexture(string data, int width, int height)
    {
        BarcodeWriter writer = new BarcodeWriter();
        writer.Format = BarcodeFormat.QR_CODE;
        var encodingOptions = new QrCodeEncodingOptions
        {
            Width = width,
            Height = height
        };
        writer.Options = encodingOptions;
        Color32[] pixels = writer.Write(data);
        Texture2D texture = new Texture2D(width, height);
        texture.SetPixels32(pixels);
        texture.Apply();
        return texture;
    }
}
