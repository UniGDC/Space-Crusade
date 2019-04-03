using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineGun : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPre;
	public GameObject muzzleFlash;
	public AudioSource shootSound; 

	public cameraShake _cameraShake;

	public float fireSpeed = 0.1f;
	private float fireSpeedRef;
    // Start is called before the first frame update
    void Start()
    {
		fireSpeedRef = fireSpeed;   
    }

    // Update is called once per frame
    void Update()
    {
		fireSpeed -= Time.deltaTime;
		if (fireSpeed <= 0 && Input.GetButton("Fire1"))
		{
			shooting();
			fireSpeed = fireSpeedRef;
		}
		/*if (Input.GetButtonDown("Fire1"))
		{
			shooting();
		}*/
		
	}

	void shooting()
	{
		Instantiate(bulletPre, firePoint.position, firePoint.rotation);
		Instantiate(muzzleFlash, firePoint.position, firePoint.rotation, this.gameObject.transform);
		StartCoroutine(_cameraShake.shake(.15f, .4f));
		shootSound.Play();
	}

	
}
