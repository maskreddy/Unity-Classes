using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trnsfmTrnslt : MonoBehaviour
{
    float moveSpeed = 10;


    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
    }
}