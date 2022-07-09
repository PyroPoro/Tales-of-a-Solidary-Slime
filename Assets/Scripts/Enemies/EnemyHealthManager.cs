using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
    [SerializeField] private float enemyHealth;
    private float enemyMaxHealth;
    private Rigidbody2D rb;
    public GameObject xpDrop;
    public int xpDropped;
    public Vector3 HealthBarPosition;
    public GameObject HealthBarPrefab;
    public GameObject hpBarCanvas;
    public GameObject HealthBar;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        xpDropped = 3;
        enemyMaxHealth = enemyHealth;
        hpBarCanvas = GameObject.FindGameObjectWithTag("hpBarCanvas");
        HealthBar = Instantiate(HealthBarPrefab, hpBarCanvas.transform);
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
            Destroy(HealthBar);
        }
        HealthBar.transform.GetChild(1).gameObject.GetComponent<Image>().fillAmount = enemyHealth/enemyMaxHealth;
        HealthBar.transform.position = transform.position + HealthBarPosition;
    }

    public void takeDamage(float damage){
        enemyHealth -= damage;
    }
}
