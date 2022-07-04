﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float damage;
    public float range;
    public float atkSpeed;
    public float kbPower;
    public float magic;
    public float sizeX;
    public float damageX;
    public float kbPowerX;
    public float atkSpeedX;
    public float magicX;
    public Vector3 position;
    public Vector3 slashPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(sizeX, sizeX, 1);
    }

    public void DamageEnemies(Vector3 pos){
        position = pos;
        Collider2D[] cols = Physics2D.OverlapBoxAll(pos, new Vector2(range*sizeX,range*sizeX), 0);
        foreach(Collider2D col in cols){
            if (col.gameObject.tag == "Enemy"){
                col.gameObject.GetComponent<EnemyHealthManager>().takeDamage(damage * damageX);
                col.gameObject.GetComponent<EnemyMovement>().SetKnockbackInfo(Time.time + 0.2f, kbPower * kbPowerX); 
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(position, new Vector2(range*sizeX,range*sizeX));
    }
}
