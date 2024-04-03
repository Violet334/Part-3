using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Start()
    {
        text.text = "...";
    }
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.text = "...";
        }
    }
}
