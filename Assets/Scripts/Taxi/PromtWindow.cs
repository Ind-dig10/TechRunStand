using UnityEngine;
using UnityEngine.UI;

//TODO
public class PromtWindow : BaseWindow
{
    [SerializeField] GameObject promtPanel;
    [SerializeField] GameObject promt_1;
    [SerializeField] GameObject promt_2;

    [SerializeField] Button nextStepButton;
    [SerializeField] Button backStepButton;

    public void ShowPromt()
    {
        promt_1.gameObject.SetActive(true);
        promt_2.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ShowPromt_2()
    {
        promt_2.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ClosePropt()
    {
        promtPanel.gameObject.SetActive(false);
    }
}
