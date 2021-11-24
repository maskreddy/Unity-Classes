using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject enemy;

    private float spawnInterval;
    public float startSpnTimer;

    void Update()
    {
        if (spawnInterval <= 0) //Check the time b/w spawn is lessthan or equal to 0.
        {
            //If its equal to 0, C# knows that its time spawn an enemy

            Instantiate(enemy, transform.position, Quaternion.identity);
            spawnInterval = startSpnTimer;

        }
        else //if not, spawntimer should gradually be decreased until it is 0
        {
            spawnInterval -= Time.deltaTime;
        }
    }
}
