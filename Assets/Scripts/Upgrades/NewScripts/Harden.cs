using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Harden : UpgradeClass
{
    void Start(){
        upgradeValue = 0.05f;
        upgradeLevel = 1;
        upgradeDescriptionText = transform.GetChild(0).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(1).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeName = "Harden 1";
        upgradeNameText.text = upgradeName;
        upgradeDescription1 = "Reduces damage taken by ";
        upgradeDescription2 = "%.";
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
    }

    void Update(){

    }

    public void applyUpgrade(){
        Player.GetComponent<PlayerStats>().def += upgradeValue;
        upgradeValue += 0.05f * upgradeLevel;
        upgradeLevel++;
        Player.GetComponent<PlayerStats>().harden++;
        upgradeName = "Harden " + upgradeLevel.ToString();
        upgradeNameText.text = upgradeName;
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
        resumeGame();
    }
}
