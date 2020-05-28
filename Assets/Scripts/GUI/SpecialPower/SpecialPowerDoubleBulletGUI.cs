public class SpecialPowerDoubleBulletGUI : SpecialPowerGUI
{
    protected override void btnClick()
    {
        base.btnClick();

        Utility.gameManager.EnableDoubleBulletsActive(true);
    }

}
