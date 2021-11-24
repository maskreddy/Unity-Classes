using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dstryBoth : MonoBehaviour
{
    public float moveSpeed;
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(x * moveSpeed * Time.deltaTime, y * moveSpeed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Killer"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
