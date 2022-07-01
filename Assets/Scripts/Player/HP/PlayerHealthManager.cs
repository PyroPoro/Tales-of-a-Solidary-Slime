using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0) {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionStay2D(Collision2D col){
        if (col.gameObject.tag == "Enemy"){
            if (col.gameObject.GetComponent<EnemyMovement>().canHit){
                playerHealth -= col.gameObject.GetComponent<EnemyMovement>().getContactDamage();
                col.gameObject.GetComponent<EnemyMovement>().hitCooldown = Time.time + 1f;
            }
        }
    }
}
