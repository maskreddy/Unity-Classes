using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitedMovement : MonoBehaviour
{
    private Vector2 targetpos;
    public float Ymovement;

    //public float speed; //Create speed variable to use in smooth movement
    public float maxY; // By Creating the max & Min Y values, We can limit the movement in Y Axis
    public float minY;
    public int health = 100; //To take damage. Called in the enemy/damager script then triggered. 


    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime); //Moves smoothly at a proper speed
        //This Time.deltaTime ensures that the player speed is same on all types of computers
        
        if(Input.GetKeyDown(KeyCode.UpArrow) /*&& transform.position.y < maxY*/)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y + Ymovement);
            transform.position = targetpos; //Hard Movement
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow) /*&& transform.position.y > minY*/)
        {
            targetpos = new Vector2(transform.position.x, transform.position.y - Ymovement);
            transform.position = targetpos;
        }

    }
}
