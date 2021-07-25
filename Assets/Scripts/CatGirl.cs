using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGirl : Girl
{
    void Start()
    {
        damage_taken = 3;
    }
    
    public override void Run()
    {
        anim.SetBool("isRun", true);
    }

    public override void HurtAction()
    {
        anim.SetBool("isRun", false);
        anim.SetTrigger("hurt");
    }
}
