public class SpecialPowerTwoMoreGUI : SpecialPowerGUI
{
    protected override void btnClick()
    {
        base.btnClick();

        Utility.gameManager.EnableTwoMoreBulletsActive(true);
    }

}
