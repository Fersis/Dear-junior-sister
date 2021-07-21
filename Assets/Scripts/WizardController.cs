using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    
    void ResetAnimation()
    {
        anim.SetBool("isLookUp", false);
        anim.SetBool("isRun", false);
        anim.SetBool("isJump", false);
    }

    public void Run()
    {
        ResetAnimation();
        anim.SetBool("isRun", true);
    }
}
