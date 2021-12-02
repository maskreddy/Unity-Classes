using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayVaribl : MonoBehaviour
{
    void Update()
    {
        // Creates a Ray from this object, moving forward
        //Ray ray = new Ray(transform.position, transform.forward);

        // Creates a Ray from the center of the viewport
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
    }

    void FireRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitData;

        Physics.Raycast(ray, out hitData);
    }
}
