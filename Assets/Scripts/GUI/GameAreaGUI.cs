using UnityEngine;

public class GameAreaGUI : MonoBehaviour
{
    public BulletsGUI bulletsGUI;
    public CharactersGUI charactersGUI;

    public void Initialize()
    {
        gameObject.SetActive(true);

        bulletsGUI.Initialize();
        charactersGUI.Initialize();

    }

}
