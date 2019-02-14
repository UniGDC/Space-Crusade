using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public int health = 100;
    private NavMeshAgent agent;
    public GameObject player;

	public GameObject deathEffect;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(player.transform.position);
        
    }
    public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
        Debug.Log("enemy dead");
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
