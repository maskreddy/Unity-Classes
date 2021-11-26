using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aadamager : MonoBehaviour
{
    public int damage = 1;
    public float speed;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //To take the player damage. To do this, the player should have health
            other.GetComponent<limitedMovement>().health -= damage; //Called from the limitedMovement Script.
            Debug.Log(other.GetComponent<limitedMovement>().health);
            Destroy(gameObject);
        }    
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
