using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    private Vector3 slashPosOriented;
    private bool isAnimating;
    private bool isAttacking;
    private Animator anim;
    private Animator slashAnim;
    private Animator playerAnim;
    private GameObject CurrentWeapon;
    private WeaponScript weapScript;
    private float atkSpeed;
    public GameObject slash;
    public Vector3 slashPos;
    // Start is called before the first frame update
    void Start()
    {
        isAnimating = false;
        CurrentWeapon = transform.GetChild(0).gameObject;
        slashPos = transform.position-transform.parent.position;
        weapScript = CurrentWeapon.GetComponent<WeaponScript>();
        anim = GetComponent<Animator>();
        playerAnim = transform.parent.GetChild(1).gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAnimating){
            if (Input.GetKey(KeyCode.Mouse0)){
                atkSpeed = weapScript.atkSpeed * weapScript.atkSpeedX;
                anim.SetFloat("atkSpeed", atkSpeed);
                playerAnim.SetFloat("atkSpeed", atkSpeed);
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
        float size = weapScript.sizeX * weapScript.range;
        slashObj.transform.localScale = new Vector3(size, size, 1);
        slashAnim = slashObj.GetComponent<Animator>();
        slashAnim.SetFloat("atkSpeed", atkSpeed);
    }

    public void CheckEnemies(){
        weapScript.DamageEnemies(transform.GetChild(0).GetChild(0).position);
    }

    public bool GetIsAttacking(){
        return isAttacking;
    }
}
