using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private bool isAnimating;
    public string swordAttackAnimName;
    // Start is called before the first frame update
    void Start()
    {
        isAnimating = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAnimating){
            if (Input.GetKey(KeyCode.Mouse0)){
                anim.Play(swordAttackAnimName);
                isAnimating = true;
            }
        }
    }

    public void EndAnimation(){
        isAnimating = false;
    }
}
