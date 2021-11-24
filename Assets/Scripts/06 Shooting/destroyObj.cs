using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObj : MonoBehaviour
{
    public float moveSpeed;
    public GameObject other;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.Translate(x * moveSpeed * Time.deltaTime, y * moveSpeed * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
