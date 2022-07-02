using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haste1 : UpgradeClass
{
    public void applyUpgrade(){
        Player.GetComponent<PlayerMove>().moveSpeedX += 0.1f;
        resumeGame();
    }
}
