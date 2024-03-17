using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO
public class QRCodeWindow : BaseWindow
{
    [SerializeField] GameObject qrPanel;

    [SerializeField] GameObject chank_1;
    [SerializeField] GameObject chank_2;

    [SerializeField] Button okButton;
    [SerializeField] Button cancelButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        qrPanel.gameObject.SetActive(false);
    }

    public void GenerateQRCode()
    {
        chank_1.gameObject.SetActive(false);
        chank_2.gameObject.SetActive(true);
    }
}
