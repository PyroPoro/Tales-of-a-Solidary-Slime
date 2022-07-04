using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float hp;
    public float def;
    public float speed;
    public int power;
    public int harden;
    public int enlighten;
    public int haste;
    public int flurry;
    public int force;
    public int colossus;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100f;
        def = 0;
        speed = 1;
        power = 0;
        enlighten = 0;
        haste = 0;
        flurry = 0;
        force = 0;
        colossus = 0;
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
                hp -= col.gameObject.GetComponent<EnemyMovement>().getContactDamage() * (1 - def);
                col.gameObject.GetComponent<EnemyMovement>().hitCooldown = Time.time + 1f;
            }
        }
    }
}
