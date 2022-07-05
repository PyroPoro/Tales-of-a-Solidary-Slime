using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Force : UpgradeClass
{
    void Start(){
        upgradeDescriptionText = transform.GetChild(0).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(1).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        upgradeLevel = Player.GetComponent<PlayerStats>().force;
        upgradeValue = 0.1f + 0.1f * upgradeLevel;
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeName = "Force " + (upgradeLevel + 1).ToString();
        upgradeNameText.text = upgradeName;
        upgradeDescription1 = "Increases Knockback Power by ";
        upgradeDescription2 = "%.";
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
    }

    void Update(){

    }

    public void applyUpgrade(){
        activeWeapon.kbPowerX += upgradeValue;
        Player.GetComponent<PlayerStats>().force++;
        resumeGame();
    }
}
