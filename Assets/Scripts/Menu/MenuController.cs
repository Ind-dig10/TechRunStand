using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TODO
public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject SelectPanel;

    [SerializeField]
    private GameObject MainMenuPanel;

    [SerializeField]
    private Button MapButton;

    [SerializeField]
    private Button PosterButton;

    [SerializeField]
    private Button DirectoryButton;

    private void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SelectPanel.activeSelf)
            {
                SelectPanel.SetActive(false);
                MainMenuPanel.SetActive(true);
            }
        }
    }
}
