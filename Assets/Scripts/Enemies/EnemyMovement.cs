using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    public float ContactDamage;
    public GameObject target;
    public bool isKnockedBack;
    public Rigidbody2D rb;
    public float knockBackTime;
    public float kbPower;
    public Vector2 direction;
    public bool canHit;
    public float hitCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetKnockbackInfo(float time, float power){
        kbPower = power;
        knockBackTime = time;
        isKnockedBack = true;
    }
    public float getContactDamage(){
        canHit = false;
        return ContactDamage;
    }

    public void moveToPlayer(){
        target = GameObject.FindGameObjectWithTag("Player");
        direction = (target.transform.position - transform.position).normalized;
        if(!isKnockedBack){
            rb.velocity = direction * moveSpeed;
        }else{
            //rb.AddForce(-direction * kbPower);
            rb.velocity = -direction * kbPower;
            if(Time.time > knockBackTime){
                isKnockedBack = false;
            }
        }
        if(direction.x > 0){
            transform.localScale = new Vector3(1,1,1);
        }else{
            transform.localScale = new Vector3(-1,1,1);
        }
    }
    public void checkHitCoolDown(){
        if (Time.time > hitCooldown){
            canHit = true;
        }
    }
}
