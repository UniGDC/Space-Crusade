using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateArm : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		difference.Normalize();

		float armRotateAngle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, armRotateAngle);

		if (this.transform.eulerAngles.z >= 90 && this.transform.eulerAngles.z <= 270)
		{
			this.transform.localScale = new Vector3(1f, -1f, 1f);
			
		}
		else
		{
			this.transform.localScale = new Vector3(1f, 1f, 1f);
		}

	}
}
