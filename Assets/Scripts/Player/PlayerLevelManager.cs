using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class PlayerLevelManager : MonoBehaviour
{
    public float xp;
    public int level;
    public Image xpbarFill;
    public float[] xpList;
    public float xpNeededForlevelUp;
    public TMP_Text levelText;
    public GameObject levelUpMenu;
    // Start is called before the first frame update
    void Start()
    {
        xp = 0;
        level = 1;
        xpList = new float[]{0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 220, 240, 260, 280, 300, 320, 340, 360, 380, 400};//level 31
    }

    // Update is called once per frame
    void Update()
    {
        xpNeededForlevelUp = xpList[level];
        xpbarFill.fillAmount = xp/xpNeededForlevelUp;
        if (xp >= xpNeededForlevelUp){
            level++;
            xp -= xpNeededForlevelUp;
            Time.timeScale = 0f;
            selectUpgrade();
        }
        levelText.text = level.ToString();
    }

    public void addXp(float addedXp){
        xp += addedXp;
    }

    public void selectUpgrade(){
        levelUpMenu.SetActive(true);
        levelUpMenu.GetComponent<RandomizeUpgrades>().resetUpgrades(4);
        levelUpMenu.GetComponent<RandomizeUpgrades>().randomUpgrades(4);
    }
}
