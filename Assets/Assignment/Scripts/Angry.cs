using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry : NPC
{
    public override void Reaction()
    {
        Attack();
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
        SendMessage("TakeDamage");
    }
}
