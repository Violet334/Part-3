using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrow;
    public Transform spawn;
    

    public override void Attack()
    {
        Instantiate(arrow, spawn);
    }

    public override Chest.ChestType CanOpen()
    {
        return Chest.ChestType.Archer;
    }
}
