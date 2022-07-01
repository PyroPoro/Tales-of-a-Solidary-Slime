using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public float damage;
    public float range;
    public float attackSpeed;
    public float kbPower;
    public Vector3 position;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageEnemies(Vector3 pos){
        position = pos;
        Collider2D[] cols = Physics2D.OverlapBoxAll(pos, new Vector2(range,range), 0);
        foreach(Collider2D col in cols){
            if (col.gameObject.tag == "Enemy"){
                col.gameObject.GetComponent<EnemyHealthManager>().takeDamage(damage);
                col.gameObject.GetComponent<EnemyMovement>().SetKnockbackInfo(Time.time + 0.2f, kbPower); 
            }
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(position, new Vector2(range,range));
    }
}
