using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger;
    public Transform spawn1;
    public Transform spawn2;
    public override Chest.ChestType CanOpen()
    {
        return Chest.ChestType.Thief;
    }

    public override void Attack()
    {
        Instantiate(dagger, spawn1);
        Instantiate(dagger, spawn2);

        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
