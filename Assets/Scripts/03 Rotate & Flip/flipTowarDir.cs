using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipTowarDir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * 20f * Time.deltaTime, 0f, 0f);

        //Flipping
        Vector3 charScale = transform.localScale;
        if (Input.GetAxis("Horizontal")<0) {
            charScale.x = -1;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            charScale.x = 1;
        }

        transform.localScale = charScale;
    }
}
