using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class reflect : MonoBehaviour
{
    public bool xy;

    public int which;
    // Start is called before the first frame update
    void Start()
    {
        // No changes here
    }

    // Update is called once per frame
    void Update()
    {
        // No changes here
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (xy)
            {
                Vector2 newVelocity = new Vector2(rb.velocity.x, -rb.velocity.y);
                rb.velocity = newVelocity; 
            }
            else
            {
                Vector2 newVelocity = new Vector2(-rb.velocity.x, rb.velocity.y);
                rb.velocity = newVelocity; 
            }
            Vector2 collisionNormal = collision.contacts[0].normal;
            rb.position += collisionNormal * 0.09f;
        }
    }
}