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

        
        
    }
    private void Update()
    {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if(distance >= 2f)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);
            
        }
        else
        {
            agent.isStopped = true;
            Debug.Log("ATTACK!!!!");
        }

        

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
