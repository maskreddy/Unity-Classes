using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToClkPt : MonoBehaviour
{
    public float speed = 10f;

    Vector2 lastClkPos;

    bool moving;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClkPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != lastClkPos) //If we are moving and the current position is not the same as the position where we clicked
        {
            float step = speed * Time.deltaTime;
            
            transform.position = Vector2.MoveTowards(transform.position,lastClkPos, step);
            //transform.position is our first parameter defining where we are. lastClkPos is where we want to go &
            //We are creating a step which means that we move to one step and then to the other step.
        }
        else {
            moving = false;
        }
    }
}
