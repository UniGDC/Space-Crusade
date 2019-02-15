using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        Vector3 playerPosition = transform.position;

        if (Input.GetKey("w"))
        {
            playerPosition.z += moveSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey("s"))
        {
            playerPosition.z -= moveSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey("d"))
        {
            playerPosition.x += moveSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey("a"))
        {
            playerPosition.x -= moveSpeed * Time.fixedDeltaTime;
        }

        transform.position = playerPosition;
    }
}
