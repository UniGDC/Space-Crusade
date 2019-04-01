using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	
	float timer = 5f;
    public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;
    public Collider2D collid;

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
    void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Debug.Log(hitInfo.name);

        enemy enemyRef = hitInfo.gameObject.GetComponent<enemy>();

		if (enemyRef != null)
		{
            Debug.Log("enemyHit");
            
			enemyRef.TakeDamage(damage);
		}

        Debug.Log("explode!!!");
		//Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

}
