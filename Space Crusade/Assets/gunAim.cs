using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunAim : MonoBehaviour {


	void Update () {

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;

        if (transform.localEulerAngles.z >= 90f)
        {
            
            transform.Rotate(new Vector3(180f, 0f, 0f));
        }
        
    }
}
