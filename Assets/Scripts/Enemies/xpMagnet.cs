using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xpMagnet : MonoBehaviour
{
    public GameObject player;
    private Vector3 direction;
    private Rigidbody2D rb;
    private float xp;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        this.enabled = false;
        xp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        direction = (player.transform.position - transform.position).normalized;
        rb.velocity = direction * 7;
    }
    public float getXp(){
        return xp;
    }
}
