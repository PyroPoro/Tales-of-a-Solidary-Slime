﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float hp;
    public float def;
    public float speed;
    public int power;
    public int harden;
    public int enlighten;
    public int haste;
    public int flurry;
    public int force;
    public int colossus;
    public float powerX;
    public float hardenX;
    public float enlightenX;
    public float hasteX;
    public float flurryX;
    public float forceX;
    public float colossusX;
    public GameObject UpgradeMenu;
    public GameObject currentWeapon;
    public string weaponClass;
    public string currentClass;
    public int classTier;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100f;
        def = 0;
        speed = 1;
        power = 0;
        enlighten = 0;
        haste = 0;
        flurry = 0;
        force = 0;
        colossus = 0;
        weaponClass = "sword";
        currentClass = "Sword Slime";
        classTier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0) {
            Destroy(this.gameObject);
        }
        currentWeapon = transform.GetChild(0).GetChild(0).gameObject;
        WeaponScript ws = currentWeapon.GetComponent<WeaponScript>();
        ws.damageX = 1+powerX;
        ws.kbPowerX = 1+forceX;
        ws.atkSpeedX = 1+flurryX;
        ws.magicX = 1+enlightenX;
        ws.sizeX = 1+colossusX;
    }

    void OnCollisionStay2D(Collision2D col){
        if (col.gameObject.tag == "Enemy"){
            if (col.gameObject.GetComponent<EnemyMovement>().canHit){
                hp -= col.gameObject.GetComponent<EnemyMovement>().getContactDamage() * (1 - def);
                col.gameObject.GetComponent<EnemyMovement>().hitCooldown = Time.time + 1f;
            }
        }
    }
}
