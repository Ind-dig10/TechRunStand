using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO
public class PosterWindow : MonoBehaviour
{
    [SerializeField] GameObject QrWindow;

    public bool IsActiveQr { get; private set; }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void GenerateQRCode()
    {
        IsActiveQr = !IsActiveQr;
        QrWindow.SetActive(IsActiveQr);
    }
}
