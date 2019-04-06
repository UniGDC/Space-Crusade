using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
	public float speed;
	public float stoppingDistance;

	public int score;
	public float health;
	public Player playerScript;
	public float damageCounter = 0.0f;
	public GameObject deathEffect;

	public AudioSource attackSound;

	public scoreCounter scoreCounterRef;

	private GameObject playerObj;

	public Slider healthBar;
	// Start is called before the first frame update
	void Start()
    {
		playerObj = GameObject.FindGameObjectWithTag("Player");
		playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		scoreCounterRef = GameObject.Find("_gameManager").GetComponent<scoreCounter>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
		healthBar.value = health / 100f;
		damageCounter -= Time.deltaTime;
		if (Vector2.Distance(transform.position, playerObj.transform.position) > stoppingDistance)
		{
			transform.position = Vector2.MoveTowards(transform.position, playerObj.transform.position, speed * Time.deltaTime);
		}
		else if (damageCounter <= 0.0f)
		{
			if (playerScript.isDead == false)
			{
				Attack();
				damageCounter = 1.0f;
			}
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
		attackSound.Play();
	}

	void Die()
	{
		scoreCounterRef.totalScore += score;
		Debug.Log("enemy dead");
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);

	}


}
