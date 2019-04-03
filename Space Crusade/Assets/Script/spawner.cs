using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{

	public GameObject[] spawnPoint;
	public GameObject[] enemyObj;

	private int randomNum;

	public int enemyNum;

	public float timer = 10f;
	public Text timerText;

	public float spawnOffset = 1f;
	private float spawnOffsetRef;


	private float timerRef;
    // Start is called before the first frame update
    void Start()
    {
		timerRef = timer;
		spawnOffsetRef = spawnOffset;
	}

    // Update is called once per frame
    void Update()
    {
		
		timerText.text = Mathf.RoundToInt(timer).ToString();
		timer -= Time.deltaTime;
		if (timer <= 0f)
		{
			StartCoroutine(spawnEnemy(enemyNum));
			timer = timerRef;
	
		}
		
    }

	public IEnumerator spawnEnemy(int enemiesToSpawn)
	{
		for (int i = 0; i < enemiesToSpawn; i++)
		{
			randomNum = Mathf.RoundToInt(Random.Range(0f, spawnPoint.Length - 1f));
			Instantiate(enemyObj[0], spawnPoint[randomNum].transform);
			yield return new WaitForSeconds(spawnOffset);
		}
	
	}
}
