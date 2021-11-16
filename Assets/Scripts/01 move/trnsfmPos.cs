using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trnsfmPos : MonoBehaviour
{
    private void FixedUpdate()
    {
        //transform.position = new Vector2(12f, transform.position.y);

        //Here when we add this script component and hit play, the object's position will change immediately.
        //We changed the position of the object in x coordinate but not in y coordinate.
        //We can notice that the cube position changes in the very next frame immediately. 


        transform.position = new Vector2(transform.position.x + .01f, transform.position.y);

        //When we change the X-Coordinate to something that takes the current x-coordinate and adds it to a value to the object and it starts to move in a constant speed
        //If we need an object to snap to a point, we can use this method

    }


}
