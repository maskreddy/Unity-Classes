using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crctrScrnClmpr : MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;
    public float moveSpeed;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2; //As we are calculating the size of our objects sprite renderer size we should divide the x & y sizes /2 to hold the object at the edge
        playerHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        float hrzntlmove = Input.GetAxisRaw("Horizontal");
        float vrtclmove = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(hrzntlmove, vrtclmove, 0) * moveSpeed * Time.deltaTime);

        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x+playerWidth, screenBounds.x * -1 -playerWidth);
        //viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x  * -1 + playerWidth, screenBounds.x - playerWidth);

        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y+playerHeight, screenBounds.y * -1 -playerHeight);
        //viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y  * -1 + playerHeight * -1, screenBounds.y - playerHeight);

        /* Orthographic and Perspective cameras have a reversed axis when using screenToWorldPoint.
         * Makesure that you assignt he Main Camera Object in the Main Camera field in Inspector.*/

        transform.position = viewPos;
    }
}










/* public Camera MainCamera;
    private Vector2 screenBounds;
    private float playerWidth;
    private float playerHeight;

    void Start () {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        playerWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        playerHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
    }

    void LateUpdate(){
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + playerWidth, screenBounds.x - playerWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + playerHeight, screenBounds.y - playerHeight);
        transform.position = viewPos;
    }
}
*/