using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehaviorScript : MonoBehaviour
{
    private Rigidbody2D rigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        rigidBody2d.velocity = new Vector2(-5, 3);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
