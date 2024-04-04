using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    //get reference to text on bottom of the screen
    public TextMeshProUGUI text;
    private void Start()
    {
        //default text is quiet
        text.text = "...";
    }
    //change the text if the player is close to the chests
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.text = "...";
        }
    }
}
