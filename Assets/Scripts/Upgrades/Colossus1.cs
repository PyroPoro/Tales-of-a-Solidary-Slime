using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colossus1 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.sizeX += 0.1f;
        resumeGame();
    }
}
