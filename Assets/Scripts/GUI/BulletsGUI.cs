using UnityEngine;

public class BulletsGUI : MonoBehaviour
{
    public GameObject prefab;
    public Transform content;

    public void Initialize()
    {
        gameObject.SetActive(true);

        ClearContent();
    }

    private void ClearContent()
    {
        for (int i = 0; i < content.childCount; i++)
            Destroy(content.GetChild(i).gameObject);
    }

    public void CreateBullet(Vector3 startingPosition, BulletDirection bulletDirection)
    {        
        GameObject go = Utility.InstantiatePrefab(prefab, content, startingPosition);
        BulletGUI bulletGUI = go.GetComponent<BulletGUI>();
        bulletGUI.Initialize(bulletDirection);
    }

}
