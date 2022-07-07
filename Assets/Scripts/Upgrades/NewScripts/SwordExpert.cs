using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordExpert : UpgradeClass
{
    void Start(){
        upgradeDescriptionText = transform.GetChild(4).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(5).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeName = "Sword Expert ";
        upgradeNameText.text = upgradeName;
        upgradeDescription1 = "Changes Class to Sword Expert";
        upgradeDescriptionText.text = upgradeDescription1;
    }

    void Update(){

    }

    public void applyUpgrade(){
        // activeWeapon.sizeX += upgradeValue;
        Player.GetComponent<PlayerStats>().currentClass = "Sword Expert";
        resumeGame();
    }
}
