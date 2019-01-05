using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;

    void FixedUpdate()
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
    }
}
