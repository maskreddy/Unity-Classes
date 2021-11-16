using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rbdvel : MonoBehaviour
{
    //When we hit play, we can see the object moving in a constant velocity
    //If we need this kind of movement with collision & physics, then we can use velocity
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(2f, 0f);
    }
}