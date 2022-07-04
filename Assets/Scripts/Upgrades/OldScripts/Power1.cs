using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power1 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.damageX += 0.1f;
        resumeGame();
    }
}
