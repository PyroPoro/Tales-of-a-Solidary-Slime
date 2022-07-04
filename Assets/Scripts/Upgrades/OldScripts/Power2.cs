using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power2 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.damageX += 0.25f;
        resumeGame();
    }
}
