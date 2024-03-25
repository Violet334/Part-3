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
        StopAllCoroutines();
        StartCoroutine(Dash());
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitUntil(()=> movement.magnitude < 0.1);
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(1);
        Instantiate(dagger, spawn1);
        yield return new WaitForSeconds(1);
        Instantiate(dagger, spawn2);
    }
}
