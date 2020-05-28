using System;
using UnityEngine;
using System.Collections.Generic;

public class SpecialPowersGUI : MonoBehaviour
{
    private List<SpecialPowerGUI> specialPowers;

    [Serializable]
    public class SpecialPowers
    {
        public SpecialPowerTwoMoreGUI specialPowerTwoMoreGUI;
        public SpecialPowerDoubleBulletGUI specialPowerDoubleBulletGUI;
        public SpecialPowerQuickGUI specialPowerQuickGUI;
        public SpecialPowerSpeedGUI specialPowerSpeedGUI;
        public SpecialPowerDoubleCharacterGUI specialPowerDoubleCharacterGUI;
    }

    public SpecialPowers sps = new SpecialPowers();
    public Color activeColor = Color.green;
    public Color passiveColor = Color.red;

    private int useSpecialPowerCount;
    public void Initialize()
    {
        gameObject.SetActive(true);

        specialPowers = new List<SpecialPowerGUI>();
        specialPowers.Add(sps.specialPowerTwoMoreGUI);
        specialPowers.Add(sps.specialPowerDoubleBulletGUI);
        specialPowers.Add(sps.specialPowerQuickGUI);
        specialPowers.Add(sps.specialPowerSpeedGUI);
        specialPowers.Add(sps.specialPowerDoubleCharacterGUI);

        useSpecialPowerCount = 0;

        InitializeSpecialPowers();
    }
    private void InitializeSpecialPowers()
    {
        for (int i = 0; i < specialPowers.Count; i++)
            specialPowers[i].Initialize();
    }

    public void IncreaseSpecialPower()
    {
        useSpecialPowerCount++;
        if(useSpecialPowerCount >= Utility.gameManager.getSpecialityCount())
        {
            for (int i = 0; i < specialPowers.Count; i++)
                if(!specialPowers[i].isActive())
                    specialPowers[i].SetInteractable(false);
        }
    }

}
