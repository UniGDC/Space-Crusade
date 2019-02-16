using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    float timer = 10f;
    public float speed = 20f;
	public int damage = 40;
	public Rigidbody rb;
	public GameObject impactEffect;
    public Collider collid;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
        collid = GetComponent<BoxCollider>();
	}

    private void Update()
    {
        
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter (Collider hitInfo)
	{
        Enemy enemy = hitInfo.gameObject.GetComponent<Enemy>();

		if (enemy != null)
		{
            Debug.Log("enemyHit");
            
			enemy.TakeDamage(damage);
		}

        Debug.Log("explode!!!");
		//Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

	
}
