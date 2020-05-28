using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterGUI : MonoBehaviour
{
    private float waitTimeForDoubledBullet = 0.1f;

    private BulletsGUI bulletsGUI;
    public void Initialize()
    {
        gameObject.SetActive(true);

        bulletsGUI = Utility.guiManager.guiRects.gameSceneRect.gameAreaGUI.bulletsGUI;

        StopAllCoroutines();
        StartCoroutine(CreateBullet());
    }

    private IEnumerator CreateBullet()
    {
        yield return new WaitForSeconds(Utility.gameManager.getBulletCreationDuration());

        List<BulletDirection> extraBulletDirections = Utility.gameManager.getExtraBulletDirections();
        for(int i = 0 ; i < extraBulletDirections.Count; i++)
            bulletsGUI.CreateBullet(transform.position, extraBulletDirections[i]);

        for (int i = 0 ; i < Utility.gameManager.getBulletCount(); i++)
        {
            bulletsGUI.CreateBullet(transform.position, BulletDirection.Right);
            yield return new WaitForSeconds(waitTimeForDoubledBullet);
        }

        StartCoroutine(CreateBullet());
    }

}
