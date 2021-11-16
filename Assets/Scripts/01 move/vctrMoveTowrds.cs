using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vctrMoveTowrds : MonoBehaviour
{
    //vector2.MoveTowards function
    //This function takes 2 vector values and a speed value. 1st on is the initial position vector value and the second one is the end position. Speed value is given at the end.
    //If our game object wnats to interact with physics, we need to add the RigidBody Component to the object
    //if we use any of these 6 functions, Remember to use the FixedUpdate & Time.deltaTime as they will help in smoothening the movements while woking in physics.
    //Time.deltaTime makes every movement frame rate independent and fixed update will help to call the method even if loading of the next frame is delayed


    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards (transform.position, new Vector2 (5f, transform.position.y) ,1f * Time.deltaTime);
    }
}
