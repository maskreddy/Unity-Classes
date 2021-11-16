using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Rotating Object towards movement

public class rotateTowards : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector2 moveDir = new Vector2(horizontalMove, verticalMove);
        float inputMagnitude = Mathf.Clamp01(moveDir.magnitude);
        moveDir.Normalize();

        transform.Translate(moveDir * speed * inputMagnitude * Time.deltaTime, Space.World);

        if(moveDir != Vector2.zero)
        {
            Quaternion toRot = Quaternion.LookRotation(Vector3.forward, moveDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRot, rotSpeed * Time.deltaTime);
        }
    }
}
