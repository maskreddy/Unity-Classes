using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
    {

    public Transform raycastPoint;
    public float damage = 10f;
    public float range = 100f;

    //In Raycast, We wont be using the Bullet Prefab. Here Everything's done with the script

    //public Transform rayPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootRay(); //Here We are calling the Shoot Function that we've created below
        }
    }

    void ShootRay()
    {
        RaycastHit2D hit = Physics2D.Raycast(raycastPoint.position, raycastPoint.right, range);
        if(hit.collider != null)
        {
            Debug.Log(hit.transform.name);

            target target = hit.transform.GetComponent<target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}