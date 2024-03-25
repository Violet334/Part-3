using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public ChestType type;
    public Animator animator;
    public enum ChestType { Villager, Merchant, Archer}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Villager villager;
        if(collision.gameObject.TryGetComponent<Villager>(out villager))
        {
            if(type == ChestType.Villager)
            {
                animator.SetBool("IsOpened", true);
            } else if(type == villager.CanOpen()) 
            {
                animator.SetBool("IsOpened", true);
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
