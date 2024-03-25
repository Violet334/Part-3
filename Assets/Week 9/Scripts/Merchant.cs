using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Villager
{
    // Start is called before the first frame update
    

    public override Chest.ChestType CanOpen()
    {
        return Chest.ChestType.Merchant;
    }
}
