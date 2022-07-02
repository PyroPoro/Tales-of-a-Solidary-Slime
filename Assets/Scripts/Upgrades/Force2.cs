using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force2 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.kbPowerX += 0.25f;
        resumeGame();
    }
}
