using UnityEngine;
using UnityEngine.UI;
using System;

public class BaseWindow : MonoBehaviour
{
    public virtual event Action onCloseButtonClicked;

    [SerializeField] protected Button closeButton;

    public bool IsActive { get; private set; }

    protected virtual void Start()
    {
        closeButton?.onClick.AddListener(CloseButton_OnClick);
    }

    public virtual void Show()
    {
        if (IsActive)
        {
            return;
        }

        gameObject.SetActive(true);
        IsActive = true;
    }

    public void Close()
    {
        CloseButton_OnClick();
    }

    protected virtual void CloseButton_OnClick()
    {
        onCloseButtonClicked?.Invoke();
        if (IsActive)
        {

            IsActive = false;
            gameObject.SetActive(false);
        }


    }
}
