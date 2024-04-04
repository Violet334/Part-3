using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Friendly : NPC
{
    //get reference to the text used in the item script
    public TextMeshProUGUI text;
    static void ResetAffection()
    {
        //reset affection meter after 5
        if (affection > 5)
        {
            affection = 0;
        }
    }
    //add updated text if affection is high enough
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
