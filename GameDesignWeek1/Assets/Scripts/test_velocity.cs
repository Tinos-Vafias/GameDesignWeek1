using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_velocity : MonoBehaviour
{
    private Rigidbody2D rigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        rigidBody2d.velocity = new Vector2(-5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
