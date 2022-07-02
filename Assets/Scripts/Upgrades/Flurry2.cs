using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flurry2 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.atkSpeedX += 0.25f;
        resumeGame();
    }
}
