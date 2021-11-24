using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dstry : MonoBehaviour
{

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<SpriteRenderer>()); //This will destroy the objects Mesh Renderer component and makes it invisible. The renderer type should be mentioned correctly.
        }
        */

        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject, 2f); //Here we added a Delay of 2f (seconds)
        }
    }
}
