using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adfrce : MonoBehaviour
{
    //In addforce function, we are adding force in eact frame which results in the increase of the velocity of the cube along with time
    //Usually addforce will not use an Update function. Because Update function executes in every frame. So force will be added in every frame & velocity increases each frame
    //When we hit play, the cube starts increasing slowly and accelerates the velocity in every frame.
    //We can use the addforce to a button. force is added once. Because of drag, the cube's velocity will be incereased.

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(100f, 0) * Time.deltaTime);
    }

}
