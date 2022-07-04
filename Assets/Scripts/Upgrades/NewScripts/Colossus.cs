using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colossus : UpgradeClass
{
    void Start(){
        upgradeValue = 0.1f;
        upgradeLevel = 1;
        upgradeDescriptionText = transform.GetChild(0).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(1).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeDescription1 = "Increases Weapon or Projectile Size by ";
        upgradeDescription2 = "%.";
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
        upgradeName = "Colossus " + upgradeLevel.ToString();
        upgradeNameText.text = upgradeName;
    }

    void Update(){

    }

    public void applyUpgrade(){
        activeWeapon.sizeX += upgradeValue;
        upgradeValue += 0.1f * upgradeLevel;
        upgradeLevel++;
        Player.GetComponent<PlayerStats>().colossus++;
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
        upgradeName = "Colossus " + upgradeLevel.ToString();
        upgradeNameText.text = upgradeName;
        resumeGame();
    }
}
