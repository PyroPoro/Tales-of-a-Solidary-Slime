using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    private Vector2 movement;
    public bool facingRight;
    private bool isAttacking;
    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        isAttacking = transform.GetChild(0).GetComponent<SwordSwing>().GetIsAttacking();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        if(!isAttacking){
            if(movement.x < 0){
                transform.localScale = new Vector3(-1,1,1);
                facingRight = false;}
            else if (movement.x > 0){
                transform.localScale = new Vector3(1,1,1);
                facingRight = true;
            }
        }

    }
    void FixedUpdate(){
        rb.velocity = movement.normalized * moveSpeed;
    }
}
