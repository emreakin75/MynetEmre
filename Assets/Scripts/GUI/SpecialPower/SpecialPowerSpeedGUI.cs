public class SpecialPowerSpeedGUI : SpecialPowerGUI
{
    protected override void btnClick()
    {
        base.btnClick();

        Utility.gameManager.EnableSpeedActive(true);
    }

}
