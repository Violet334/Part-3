using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyChest : Item
{
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.text = "Aw, you can be here";
        }
    }
}
