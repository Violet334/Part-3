using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = new Vector2(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + speed * Time.deltaTime);
    }
}
