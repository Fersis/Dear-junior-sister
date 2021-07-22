using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    protected Animator anim;
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

    public virtual void Run()
    {
        ResetAnimation();
        anim.SetBool("isRun", true);
    }
}
