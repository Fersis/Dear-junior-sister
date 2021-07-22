using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGirl : Girl
{    
    public override void Run()
    {
        anim.SetBool("isRun", true);
    }
}
