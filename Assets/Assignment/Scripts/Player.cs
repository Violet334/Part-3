using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool affection;
    Animator animator;
    public GameObject heart;
    public Transform spawn;
    public NPC npc;

    bool clickingOnSelf;
    Rigidbody2D rb;
    protected Vector2 destination;
    protected Vector2 movement;
    float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        affection = false;

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        destination = transform.position;
    }
    private void OnMouseOver()
    {
        clickingOnSelf = true;
    }

    private void OnMouseExit()
    {
        clickingOnSelf = false;
    }

    // Update is called once per frame
    void Update()
    {
        //left click: move to the click location
        if (Input.GetMouseButtonDown(0)  && !clickingOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("Walk", movement.magnitude);

        //left click on player: attack
        if (Input.GetMouseButtonDown(0) && clickingOnSelf)
        {
            animator.SetTrigger("Attack");
        }
        //right click on player: affection
        if (Input.GetMouseButtonDown(1) && clickingOnSelf)
        {
            Debug.Log("hear");
            GameObject h = Instantiate(heart, spawn.position, Quaternion.identity);
            Destroy(h, 2);
            StartCoroutine(npc.Affection());
        }
    }
    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        //flip the x direction of the game object & children to face the direction we're walking
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        //stop moving if we're close enough to the target
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }
    void TakeDamage()
    {
        animator.SetTrigger("TakeDamage");
    }
}
