using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Here we are writing a player script with Health and Scene Management System to restart Game on Destroying player when his health becomes 0.

public class restartGame : MonoBehaviour
{
    private Vector2 targt;
    public float Ymovement;
    public float speed;
    public float maxY;
    public float minY;
    public int health;

    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targt, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            targt = new Vector2(transform.position.x, transform.position.y + Ymovement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            targt = new Vector2(transform.position.x, transform.position.y - Ymovement);
            transform.position = targt;
        }
    }
}
