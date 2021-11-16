using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvNTrntwdtgt : MonoBehaviour
{
    [SerializeField] private GameObject targtPoint;
    //SerializeField displays the private variable in the inspector so that we can add our target point object into its field. Public additionally lets the other scripts access

    [SerializeField] private float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta);
        transform.position = Vector2.MoveTowards(transform.position, targtPoint.transform.position, speed * Time.deltaTime);
        transform.up = targtPoint.transform.position - transform.position;

        // transform.up or transform.right makes the objects local direction accessible rather than world direction
    }
}

