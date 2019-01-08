using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    float timer = 10f;
    public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

    private void Update()
    {
        
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D (Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
            
			enemy.TakeDamage(damage);
		}

        Debug.Log("explode!!!");
		//Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
	
}
