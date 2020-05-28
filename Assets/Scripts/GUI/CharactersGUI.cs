using UnityEngine;

public class CharactersGUI : MonoBehaviour
{
    public GameObject prefab;
    public Transform content;

    public void Initialize()
    {
        gameObject.SetActive(true);

        ClearContent();

        CreateCharacter();
    }

    private void ClearContent()
    {
        for (int i = 0; i < content.childCount; i++)
            Destroy(content.GetChild(i).gameObject);
    }

    public void CreateCharacter()
    {
        GameObject go = Instantiate(prefab, content, false);
        CharacterGUI characterGUI = go.GetComponent<CharacterGUI>();
        characterGUI.Initialize();
    }

}
