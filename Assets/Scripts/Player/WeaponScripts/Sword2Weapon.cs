using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword2Weapon : WeaponScript
{
    // Start is called before the first frame update
    void Start()
    {
        damage = 25f;
        damageX = 1f;
        range = 1.5f;
        atkSpeed = 1f;
        atkSpeedX = 1f;
        kbPower = 5f;
        sizeX = 1f;
        kbPowerX = 1f;
    }
}
