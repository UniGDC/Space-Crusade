using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunAim : MonoBehaviour {


	void Update () {
        transform.LookAt(Input.mousePosition, Vector3.up);

        /*if (transform.localEulerAngles.z >= 90f)
        {
            
            transform.Rotate(new Vector3(180f, 0f, 0f));
        }*/

    }
}
