using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float moveSpeedX = 1f;
    private Vector2 movement;
    public bool facingRight;
    private bool isAttacking;
    public float pickupRange;
    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        pickupRange = 2;
    }

    // Update is called once per frame
    void Update()
    {
        isAttacking = transform.GetChild(0).GetComponent<SwordSwing>().GetIsAttacking();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        moveSpeedX = gameObject.GetComponent<PlayerStats>().speed;
        if(!isAttacking){
            if(movement.x < 0){
                transform.localScale = new Vector3(-1,1,1);
                facingRight = false;}
            else if (movement.x > 0){
                transform.localScale = new Vector3(1,1,1);
                facingRight = true;
            }
        }
        pickUpXp();
    }
    void FixedUpdate(){
        rb.velocity = movement.normalized * moveSpeed * moveSpeedX;
    }

    void pickUpXp(){
        Collider2D[] cols = Physics2D.OverlapBoxAll(transform.position, new Vector2(1,1)*pickupRange, 0);
        foreach (Collider2D col in cols){
            if(col.gameObject.tag == "xp"){
                col.gameObject.GetComponent<xpMagnet>().enabled = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "xp"){
            gameObject.GetComponent<PlayerLevelManager>().addXp(col.gameObject.GetComponent<xpMagnet>().getXp());
            Destroy(col.gameObject);
        }
    }
}
