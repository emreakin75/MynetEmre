using System.Collections.Generic;

public class GameManager
{
    private bool twoMoreBulletsActive;
    private bool doubleBulletsActive;
    private bool quickActive;
    private bool speedActive;
    private bool doubleCharacterActive;

    private readonly int specialityCount = 3;

    private readonly int extraBulletCount = 1;

    private readonly float bulletCreationDuration = 1f;
    private readonly float bulletCreationDurationMultiplier = 0.5f;

    private readonly float bulletNormalSpeed = 1f;
    private readonly float bulletSpeedMultiplier = 1.5f;

    private readonly float bulletDestroyTime = 30f;

    public GameManager()
    {
        twoMoreBulletsActive = false;
        doubleBulletsActive = false;
        quickActive = false;
        speedActive = false;
        doubleCharacterActive = false;
    }

    public int getSpecialityCount()
    {
        return specialityCount;
    }

    public int getBulletCount()
    {
        int bulletCount = 1;
        if (doubleBulletsActive)
            bulletCount += extraBulletCount;

        return bulletCount;
    }
    public float getBulletCreationDuration()
    {
        float duration = bulletCreationDuration;
        if (quickActive)
            duration *= bulletCreationDurationMultiplier;

        return duration;
    }
    public float getBulletSpeed()
    {
        float bulletSpeed = bulletNormalSpeed;
        if (speedActive)
            bulletSpeed *= bulletSpeedMultiplier;

        return bulletSpeed;
    }
    public float getBulletDestroyTime()
    {
        return bulletDestroyTime;
    }

    public List<BulletDirection> getExtraBulletDirections()
    {
        List<BulletDirection> bulletDirections = new List<BulletDirection>();
        if(twoMoreBulletsActive)
        {
            bulletDirections.Add(BulletDirection.TopRight);
            bulletDirections.Add(BulletDirection.BottomRight);
        }

        return bulletDirections;
    }
    public void EnableTwoMoreBulletsActive(bool enable)
    {
        twoMoreBulletsActive = enable;
    }
    public void EnableDoubleBulletsActive(bool enable)
    {
        doubleBulletsActive = enable;
    }
    public void EnableQuickActive(bool enable)
    {
        quickActive = enable;
    }
    public void EnableSpeedActive(bool enable)
    {
        speedActive = enable;
    }
    public void EnableDoubleCharacterActive(bool enable)
    {
        doubleCharacterActive = enable;
    }

}
