using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomizeUpgrades : MonoBehaviour
{
    public GameObject Colossus;
    public GameObject Enlighten;
    public GameObject Flurry;
    public GameObject Force;
    public GameObject Harden;
    public GameObject Haste;
    public GameObject Power;
    public List<GameObject> availableUpgrades;
    public PlayerStats playerStats;
    // Start is called before the first frame update
    void Start()
    {
        availableUpgrades = new List<GameObject> {Colossus, Enlighten, Flurry, Force, Harden, Haste, Power};
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void randomUpgrades(int numUpgrades){
        checkAvailability();
        List<GameObject> tempList = new List<GameObject>(availableUpgrades);
        for (int i = 0; i < numUpgrades; i++){
            int index = Random.Range(0, tempList.Count);
            Instantiate(tempList[index], transform.GetChild(i + 1));
            tempList.RemoveAt(index);
        }
    }

    public void resetUpgrades(int numUpgrades){
        for (int i = 0; i < numUpgrades; i++){
            if (transform.GetChild(i+1).childCount > 0){
                Destroy(transform.GetChild(i+1).GetChild(0).gameObject);
            }
        }
    }

    public void checkAvailability(){
        if (playerStats.colossus == 4){
            availableUpgrades.Remove(Colossus);
        }
        if (playerStats.enlighten == 4){
            availableUpgrades.Remove(Enlighten);
        }
        if (playerStats.flurry == 4){
            availableUpgrades.Remove(Flurry);
        }
        if (playerStats.force == 4){
            availableUpgrades.Remove(Force);
        }
        if (playerStats.harden == 4){
            availableUpgrades.Remove(Harden);
        }
        if (playerStats.haste == 4){
            availableUpgrades.Remove(Haste);
        }
        if (playerStats.power == 4){
            availableUpgrades.Remove(Power);
        }
    }
}
