using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzzleFlash : MonoBehaviour
{
	public float lastTImer = 0.000000000000000001f;
    
    void Update()
    {
		lastTImer -= Time.deltaTime;
		if (lastTImer <= 0f)
		{
			Destroy(this.gameObject);
		}
	}
}
