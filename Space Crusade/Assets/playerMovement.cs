using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    [SerializeField]
    private BoxCollider2D boundary;//boundary of the map

    public float moveSpeed = 10f;

    private Vector3 minBounds;
    private Vector3 maxBounds;
    private GameObject player;
    private float halfHeight;
    private float halfWidth;

    [SerializeField]
    private Camera cam;

    void Start()
    {
        player = GetComponent<GameObject>();
       // minBounds = boundary.bounds.min;
        //maxBounds = boundary.bounds.max;

        cam = cam.GetComponentInChildren<Camera>();
        halfHeight = cam.orthographicSize;
        halfWidth = cam.orthographicSize * Screen.width / Screen.height;
    }


    void Update()
    {
        Vector3 playerPosition = transform.position;

        if (Input.GetKey("w"))
        {
            playerPosition.y += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            playerPosition.y -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            playerPosition.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            playerPosition.x -= moveSpeed * Time.deltaTime;
        }

        transform.position = playerPosition;


        //clamp camera positions
        /*float xClamp = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
        float yClamp = Mathf.Clamp(transform.position.y, minBounds.y + halfWidth, maxBounds.y - halfHeight);
        transform.position = new Vector3(xClamp, yClamp, transform.position.z);*/
    }
}
