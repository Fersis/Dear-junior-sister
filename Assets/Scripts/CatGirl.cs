using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGirl : Girl
{
    void Start()
    {
        DamageTaken = 3;
    }
    
    public override void Run()
    {
        Anim.SetBool("isRun", true);
    }

    public override void HurtAction()
    {
        Anim.SetBool("isRun", false);
        Anim.SetTrigger("hurt");
    }
}
