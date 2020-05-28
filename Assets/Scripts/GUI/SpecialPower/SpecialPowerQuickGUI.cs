public class SpecialPowerQuickGUI : SpecialPowerGUI
{
    protected override void btnClick()
    {
        base.btnClick();

        Utility.gameManager.EnableQuickActive(true);
    }

}
