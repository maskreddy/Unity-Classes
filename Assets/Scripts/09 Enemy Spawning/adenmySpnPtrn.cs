using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adenmySpnPtrn : MonoBehaviour
{
    public GameObject[] enmPtrn;
    private float spawnInterval;
    public float initialSpnIntrvl;
    public float minspnIntrvl;
    public float spnTimeReductn;

    void Update()
    {
        if (spawnInterval <= 0.5) //Check the time b/w spawn is lessthan or equal to 0.
        {
            //If its equal to 0.5, C# knows that its time to spawn an enemy
            int rndm = Random.Range(0, enmPtrn.Length);
            Instantiate(enmPtrn[rndm], transform.position, Quaternion.identity);
            spawnInterval = initialSpnIntrvl;
            if (initialSpnIntrvl > minspnIntrvl)
            {
                initialSpnIntrvl -= spnTimeReductn;
            }
        }

        else //if not, spawntimer should gradually be decreased until it is 0.6
        {
            spawnInterval -= Time.deltaTime;
        }
    }
}
