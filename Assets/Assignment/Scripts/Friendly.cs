using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Friendly : NPC
{
    public TextMeshProUGUI text;
    public Transform spawn2;
    static void ResetAffection()
    {
        if (affection == 5)
        {
            affection = 0;
        }
    }

    protected override void Update()
    {
        base.Update();
        if(affection == 5)
        {
            text.text = "Aww";
            ResetAffection();
        }
        
    }
}
