using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    public GameObject player;
    public float hp;
    public Image HpBarFill;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        HpBarFill = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        hp = player.GetComponent<PlayerHealthManager>().playerHealth;
        HpBarFill.fillAmount = hp/100;
    }
}
