using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] private float enemyHealth;
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0) {
            Destroy(this.gameObject);
        }
    }

    public void takeDamage(float damage){
        enemyHealth -= damage;
    }
}
