using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeClass : MonoBehaviour
{
    // public string upgradeDescription;
    // public string upgradeName;
    public GameObject Player;
    public WeaponScript activeWeapon;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        activeWeapon = Player.transform.GetChild(0).GetChild(0).gameObject.GetComponent<WeaponScript>();
    }

    public void resumeGame(){
        Time.timeScale = 1;
        transform.parent.parent.gameObject.SetActive(false);
    }
}
