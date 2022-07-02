using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force1 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.kbPowerX += 0.1f;
        resumeGame();
    }
}
