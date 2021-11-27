using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessBG : MonoBehaviour
{
    public float speed;
    public float startPos;
    public float endPos;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //Moves the BG towards Left (-X)
        
        if(transform.position.x <= endPos)
        {
            if(transform.position.x <= endPos) 
            {
                Vector2 bgPos = new Vector2(startPos, transform.position.y);
                transform.position = bgPos;
            }
        }
    }
}