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
    public GameObject upgradeIcon;
    public Sprite upgradeIcon1;
    public Sprite upgradeIcon2;
    public Sprite upgradeIcon3;
    public Sprite upgradeIcon4;
    public GameObject upgradeBackground;
    public bool available;
    public GameObject upgradeMenu;

    public void resumeGame(){
        Time.timeScale = 1;
        transform.parent.parent.gameObject.SetActive(false);
    }

    public void changeCard(){
        if (upgradeLevel == 0){
            upgradeIcon.GetComponent<Image>().sprite = upgradeIcon1;
            upgradeBackground.GetComponent<Image>().color = new Color32(0, 255, 14, 255);
        }else if (upgradeLevel == 1){
            upgradeIcon.GetComponent<Image>().sprite = upgradeIcon2;
            upgradeBackground.GetComponent<Image>().color = new Color32(0, 112, 255, 255);
        }else if (upgradeLevel == 2){
            upgradeIcon.GetComponent<Image>().sprite = upgradeIcon3;
            upgradeBackground.GetComponent<Image>().color = new Color32(190, 0, 255, 255);    
        }else if (upgradeLevel == 3){
            upgradeIcon.GetComponent<Image>().sprite = upgradeIcon4;
            upgradeBackground.GetComponent<Image>().color = new Color32(255, 221, 0, 255);
        }
    }
}
