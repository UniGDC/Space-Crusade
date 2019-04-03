using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPre;
	public GameObject muzzleFlash;
	public AudioSource shootSound;

	public cameraShake _cameraShake;

	public float fireSpeed = 1.0f;
	public float fireSpeedRef = 0.0f;
	// Start is called before the first frame update
	void Start()
	{
		

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButton("Fire1"))
		{
			fireSpeed -= Time.deltaTime;
			if (fireSpeedRef <= 0.0f)
			{
				shooting();
				fireSpeedRef = fireSpeed;
			}
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
