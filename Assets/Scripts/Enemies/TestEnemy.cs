using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : EnemyMovement
{
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ContactDamage = 5f;
        moveSpeed = 1f;
        kbPower = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();
        checkHitCoolDown();
    }
}
