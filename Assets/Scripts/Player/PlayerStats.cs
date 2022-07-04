using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float hp;
    public float atk;
    public float def;
    public float mag;
    public float agi;
    public float dex;
    public float frc;
    public float sze;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0) {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D col){
        if (col.gameObject.tag == "Enemy"){
            if (col.gameObject.GetComponent<EnemyMovement>().canHit){
                hp -= col.gameObject.GetComponent<EnemyMovement>().getContactDamage();
                col.gameObject.GetComponent<EnemyMovement>().hitCooldown = Time.time + 1f;
            }
        }
    }
}
