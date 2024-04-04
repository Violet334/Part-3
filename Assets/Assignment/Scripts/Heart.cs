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
        //set speed of the heart
        speed = new Vector2(0, 3);
    }

    // heart continuously moves upwards
    void Update()
    {
        rb.MovePosition(rb.position + speed * Time.deltaTime);
    }
}
