using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enlighten : UpgradeClass
{
    void Start(){
        upgradeValue = 0.1f;
        upgradeLevel = 1;
        upgradeDescriptionText = transform.GetChild(0).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(1).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeName = "Enlighten 1";
        upgradeNameText.text = upgradeName;
        upgradeDescription1 = "Increases Damage Dealt by Magic Attacks by ";
        upgradeDescription2 = "%.";
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
    }

    void Update(){

    }

    public void applyUpgrade(){
        activeWeapon.magicX += upgradeValue;
        upgradeValue += 0.1f * upgradeLevel;
        upgradeLevel++;
        Player.GetComponent<PlayerStats>().enlighten++;
        upgradeName = "Enlighten " + upgradeLevel.ToString();
        upgradeNameText.text = upgradeName;
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
        resumeGame();
    }
}
