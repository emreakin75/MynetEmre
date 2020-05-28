using UnityEngine;

public class BulletGUI : MonoBehaviour
{
    private float destroyTime;

    private float yMultiplier;
    public void Initialize(BulletDirection direction)
    {
        gameObject.SetActive(true);

        destroyTime = Utility.gameManager.getBulletDestroyTime();

        if (direction == BulletDirection.Right)
            yMultiplier = 0;
        if (direction == BulletDirection.TopRight)
            yMultiplier = 1;
        if (direction == BulletDirection.BottomRight)
            yMultiplier = -1;

        Destroy(gameObject, destroyTime);
    }

    private void Update()
    {
        float bulletSpeed = Utility.gameManager.getBulletSpeed();
        transform.Translate(bulletSpeed, yMultiplier * bulletSpeed, 0);
    }

}
