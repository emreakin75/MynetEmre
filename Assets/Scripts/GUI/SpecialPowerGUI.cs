using UnityEngine;
using UnityEngine.UI;

public class SpecialPowerGUI : MonoBehaviour
{
    public Button btn;
    public Image image;

    private bool _isActive;
    public void Initialize()
    {
        gameObject.SetActive(true);

        _isActive = false;
        image.color = Utility.guiManager.guiRects.gameSceneRect.specialPowersGUI.passiveColor;
        SetInteractable(true);

        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(btnClick);
    }

    protected virtual void btnClick()
    {
        _isActive = true;

        SpecialPowersGUI specialPowersGUI = Utility.guiManager.guiRects.gameSceneRect.specialPowersGUI;

        image.color = specialPowersGUI.activeColor;

        specialPowersGUI.IncreaseSpecialPower();

        btn.onClick.RemoveAllListeners();
    }

    public bool isActive()
    {
        return _isActive;
    }

    public void SetInteractable(bool enable)
    {
        btn.interactable = enable;
    }

}
