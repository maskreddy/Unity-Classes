using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trnsfmtrnslt1 : MonoBehaviour
{
    //Transform.Translate 
    //If we wnat to move our boject without interacting with the thysics, we use Transform.Translate
    //Here we can see that the translate function takes the vector2
    // when we check or hit play, the object will move in x axis in every frame that's because we used it in Ipdate method.
    //We can trigger the movement when we hit the button by using input.getkeydown function

    public float moveSpeed = 0f;

    private void FixedUpdate()
    {
        transform.Translate(new Vector2(1f, 0f) * moveSpeed * Time.deltaTime);

    }
}
