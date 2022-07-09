using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colossus : UpgradeClass
{
    void Start(){
        upgradeDescriptionText = transform.GetChild(4).gameObject.GetComponent<Text>();
        upgradeNameText = transform.GetChild(5).gameObject.GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        upgradeLevel = Player.GetComponent<PlayerStats>().colossus;
        upgradeValue = 0.1f + 0.1f * upgradeLevel;
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
        upgradeName = "Colossus " + (upgradeLevel + 1).ToString();
        upgradeNameText.text = upgradeName;
        upgradeDescription1 = "Increases Weapon or Projectile Size by ";
        upgradeDescription2 = "%.";
        upgradeDescriptionText.text = upgradeDescription1 + ((int)(upgradeValue * 100)).ToString() + upgradeDescription2;
        changeCard();
    }

    void Update(){

    }

    public void applyUpgrade(){
        Player.GetComponent<PlayerStats>().colossusX += upgradeValue;
        Player.GetComponent<PlayerStats>().colossus++;
        changeCard();
        resumeGame();
    }
}
