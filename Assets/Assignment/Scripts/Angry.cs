using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry : NPC
{
    public Player player;
    //replace the base reaction to player proximity with an attacking animation
    public override void Reaction()
    {
        Attack();
    }
    //attacking function unique to the angry npc
    private void Attack()
    {
        //play attacking animation and trigger the player's damage-taking animation
        animator.SetTrigger("Attack");
        player.SendMessage("TakeDamage");
    }
}
