using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] private float enemyHealth;
    private Rigidbody2D rb;
    public GameObject xpDrop;
    public int xpDropped;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        xpDropped = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0) {
            for (int i = 0; i < xpDropped; i++){
                float pos = Random.Range(-3.0f,3.0f) / 10.0f;
                Instantiate(xpDrop, transform.position + new Vector3(pos,pos,0), Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }

    public void takeDamage(float damage){
        enemyHealth -= damage;
    }
}
