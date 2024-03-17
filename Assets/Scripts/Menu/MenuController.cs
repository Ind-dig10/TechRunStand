using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

// TODO
public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject SelectPanel;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private GameObject MainMenuPanel;

    [SerializeField]
    private GameObject MapPanel;

    [SerializeField]
    private GameObject TaxiPanel;

    [SerializeField]
    private GameObject PosterPanel;

    [SerializeField]
    private GameObject QrCodeWindow;

    [SerializeField]
    private GameObject DirectoryWindow;

    [SerializeField]
    private GameObject ChatWindow;

    [SerializeField]
    private GameObject IdleAvatar;

    [SerializeField]
    private GameObject talkingAvatar;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SelectPanel.activeSelf)
            {
                
                animator.SetTrigger("IsStartTrigger");
                SelectPanel.SetActive(false);
                MainMenuPanel.SetActive(true);
            }
        }
    }

    public void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void ShowMapWindow()
    {
        TogglePanel(MapPanel);
    }

    public void ShowTaxiWindow()
    {
        TogglePanel(TaxiPanel);
    }

    public void ShowPosterWindow()
    {
        TogglePanel(PosterPanel);
    }

    public void ShowQrCodeWindow()
    {
        TogglePanel(QrCodeWindow);
    }

    public void ShowDirectoryWindow()
    {
        TogglePanel(DirectoryWindow);
    }

    public void ShowChatWindow()
    {
        TogglePanel(ChatWindow);
    }
}
