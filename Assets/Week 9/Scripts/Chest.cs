using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator animator;
    public enum ChestType { Villager, Merchant, Archer}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        animator.SetBool("IsOpened", true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
