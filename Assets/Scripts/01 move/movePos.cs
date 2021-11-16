using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePos : MonoBehaviour
{
    //Difference between using velocity & MovePosition is: MovePosition works well when the rigid body is kinamatic. But velocity is good when body is dynamic
    // With move position, we are settin a new position to the object in each frame
    // in MovePosition, Velocity is caliculated internally.
    // In the script we are taking the current position of the object and adding new position in each frame

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(1f, 0f) * Time.deltaTime);
    }

}
