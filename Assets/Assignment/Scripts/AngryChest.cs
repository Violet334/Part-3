using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryChest : Item
{
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        //harsh message to the player
        if (collision.CompareTag("Player"))
        {
            text.text = "Hey! You can't be here";
        }
    }
}
