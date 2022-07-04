using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeClass : MonoBehaviour
{
    // public string upgradeDescription;
    // public string upgradeName;
    public GameObject Player;
    public WeaponScript activeWeapon;
    public string upgradeDescription1;
    public string upgradeDescription2;
    public string upgradeName;
    public float upgradeValue;
    public int upgradeLevel;
    public Text upgradeDescriptionText;
    public Text upgradeNameText;

    public void resumeGame(){
        Time.timeScale = 1;
        transform.parent.parent.gameObject.SetActive(false);
    }
}
