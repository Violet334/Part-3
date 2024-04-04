using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //new static variable
    public static int affection;

    Rigidbody2D rb;
    public GameObject heart;
    public Transform spawn;
    protected Vector2 destination;
    protected Vector2 movement;
    float speed = 3;
    protected Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //affection meter starts at 0
        affection = 0;
        rb = GetComponent<Rigidbody2D>();
        destination = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        animator.SetFloat("Movement", movement.magnitude);
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
    //reaction to player proximity
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Reaction();
        }
        
    }
    //stop playing the affection coroutine if player exits proximity
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StopAllCoroutines();
        }
    }
    //base reaction function is to play the affection coroutine
    public virtual void Reaction()
    {
        StartCoroutine(Affection());
    }
    //periodically creates a heart that disappears after a few seconds above the npc
    public IEnumerator Affection() 
    {
        while(true)
        {
            GameObject h = Instantiate(heart, spawn.position, Quaternion.identity);
            Destroy(h,2);
            yield return new WaitForSeconds(2);
        }
        
    }
}
