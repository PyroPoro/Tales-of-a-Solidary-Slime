using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flurry1 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.atkSpeedX += 0.1f;
        resumeGame();
    }
}
