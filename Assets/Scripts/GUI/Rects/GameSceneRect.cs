using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneRect : RectBase
{
    public GameAreaGUI gameAreaGUI;
    public SpecialPowersGUI specialPowersGUI;
    public Button exitBtn;

    public void Initialize()
    {
        gameObject.SetActive(true);

        gameAreaGUI.Initialize();
        specialPowersGUI.Initialize();

        exitBtn.onClick.RemoveAllListeners();
        exitBtn.onClick.AddListener(exitBtnClick);
    }

    private void exitBtnClick()
    {
        SceneManager.LoadScene(0);
    }
}
