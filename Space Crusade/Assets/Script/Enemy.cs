using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	public float speed;
	public float stoppingDistance;

	public float health;
	public Player playerScript;
	public float damageCounter = 0f;
	public GameObject deathEffect;

	private GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
		playerObj = GameObject.FindGameObjectWithTag("Player");
		playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

	}

    // Update is called once per frame
    void FixedUpdate()
    {
		damageCounter -= Time.deltaTime;
		if (Vector2.Distance(transform.position, playerObj.transform.position) > stoppingDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, playerObj.transform.position, speed * Time.deltaTime);
		}
		else if (damageCounter <= 0)
		{
			Attack();
			damageCounter = 3f;
		}

    }

	public void TakeDamage(int damage)
	{
		health -= damage;
		Debug.Log("damage taken");
		if (health <= 0)
		{
			Die();
		}
	}

	void Attack()
	{
		playerScript.takeDamage(10);
	}

	void Die()
	{
		Debug.Log("enemy dead");
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}


}
