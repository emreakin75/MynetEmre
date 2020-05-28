using UnityEngine;

public class Utility : MonoBehaviour
{
    public static GUIManager guiManager;
    public static GameManager gameManager;

    public static GameObject InstantiatePrefab(GameObject prefab, Transform content, Vector3 position)
    {
        GameObject go = Instantiate(prefab, position, new Quaternion(0, 0, 0, 0)) as GameObject;
        go.transform.SetParent(content, true);
        go.GetComponent<RectTransform>().localScale = Vector3.one;
        return go;
    }
}
