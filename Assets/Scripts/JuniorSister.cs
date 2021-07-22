using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuniorSister : Girl
{
    [SerializeField] Text dialog;
    public override void Run()
    {
        dialog.gameObject.SetActive(true);
    }
}
