using UnityEngine;

//TODO
public class PosterMenuWindow : MonoBehaviour
{
    [SerializeField] GameObject Poster;
    [SerializeField] GameObject vdnhPage;

    public void Close()
    {
        Poster.gameObject.SetActive(false);
    }

    public void OpenPage_1()
    {
        vdnhPage.gameObject.SetActive(true);
    }
}