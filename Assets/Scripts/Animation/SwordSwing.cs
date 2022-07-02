using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    private Vector3 slashPosOriented;
    [SerializeField] private bool isAnimating;
    private bool isAttacking;
    private Animator anim;
    private Animator slashAnim;
    private GameObject CurrentWeapon;
    public GameObject slash;
    public Vector3 slashPos;

    // Start is called before the first frame update
    void Start()
    {
        isAnimating = false;
        anim = GetComponent<Animator>();
        slashAnim = slash.GetComponent<Animator>();
        CurrentWeapon = transform.GetChild(0).gameObject;
        slashPos = transform.position-transform.parent.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAnimating){
            if (Input.GetKey(KeyCode.Mouse0)){
                anim.Play("SwordSwing");
                isAnimating = true;
            }
        }
        if (!this.transform.parent.transform.GetComponent<PlayerMove>().facingRight){
            slashPosOriented = Vector3.Scale(slashPos, new Vector3(-1,1,1));
        } else {
            slashPosOriented = slashPos;
        }
    }

    public void SetAnimatingFalse(){
        isAnimating = false;
    }
    public void SetAttackingFalse(){
        isAttacking = false;
    }
    public void SetAttackingTrue(){
        isAttacking = true;
    }

    public void PlaySlash(){
        GameObject slashObj = Instantiate(slash, transform.parent.position + slashPosOriented, Quaternion.identity, this.transform.parent);
        float size = transform.GetChild(0).GetComponent<WeaponScript>().sizeX;
        slashObj.transform.localScale = new Vector3(size, size, 1);
    }

    public void CheckEnemies(){
        CurrentWeapon.GetComponent<WeaponScript>().DamageEnemies(transform.GetChild(0).position);//transform.parent.position + slashPosOriented
    }

    public bool GetIsAttacking(){
        return isAttacking;
    }
}
