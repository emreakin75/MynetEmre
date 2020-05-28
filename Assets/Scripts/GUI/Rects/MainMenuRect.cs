using UnityEngine.UI;

public class MainMenuRect : RectBase
{
    public Button playBtn;

    public void Initialize()
    {
        gameObject.SetActive(true);

        playBtn.onClick.RemoveAllListeners();
        playBtn.onClick.AddListener(playBtnClick);
    }

    private void playBtnClick()
    {
        Utility.guiManager.OpenGameSceneRect();
    }

}
