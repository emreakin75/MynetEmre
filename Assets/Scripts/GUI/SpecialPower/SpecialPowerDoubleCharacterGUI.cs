public class SpecialPowerDoubleCharacterGUI : SpecialPowerGUI
{
    protected override void btnClick()
    {
        base.btnClick();

        Utility.gameManager.EnableDoubleCharacterActive(true);
        Utility.guiManager.guiRects.gameSceneRect.gameAreaGUI.charactersGUI.CreateCharacter();
    }

}
