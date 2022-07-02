using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haste2 : UpgradeClass
{
    public void applyUpgrade(){
        Player.GetComponent<PlayerMove>().moveSpeedX += 0.25f;
        resumeGame();
    }
}
