using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YandexMaps;

public class MapController : MonoBehaviour
{
    public GameObject dd;
    public RawImage image;
    public Map.TypeMap typeMap;
    public Map.TypeMapLayer mapLayer;
    public int size;
    public float lat;
    public float lon;
    public List<Vector2> markers = new List<Vector2>();

    private void Start()
    {
        RectTransform rectTransform = image.rectTransform;
        int width = (int)rectTransform.rect.width; //1080
        int height = (int)rectTransform.rect.height; //1920

        Map.EnabledLayer = true;
        Map.Width = 450;
        Map.Height = 450;
        Map.Size = size;
        Map.SetTypeMap = typeMap;
        Map.SetTypeMapLayer = mapLayer;
        Map.SetMarker = markers;
        Map.Latitude = lat;
        Map.Longitude = lon;
        Map.LoadMap();
        StartCoroutine(LoadTexture());
    }

    IEnumerator LoadTexture()
    {
        yield return new WaitForSeconds(1F);
        image.texture = Map.GetTexture;
    }
}
