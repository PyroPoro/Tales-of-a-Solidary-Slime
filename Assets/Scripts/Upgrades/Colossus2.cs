using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colossus2 : UpgradeClass
{
    public void applyUpgrade(){
        activeWeapon.sizeX += 0.25f;
        resumeGame();
    }
}
