using UnityEngine;

public class Initializer : MonoBehaviour
{
    public GUIManager guiManager;

    void Start()
    {
        Utility.gameManager = new GameManager();
        Utility.guiManager = guiManager;

        Utility.guiManager.Initialize();

        Destroy(gameObject);
    }

}
