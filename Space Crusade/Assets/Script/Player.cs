using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 100;
	public Slider slider;

	public GameObject[] thingsToDisable;
	public GameObject[] thingsToEnable;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		slider.value = health/100f;
        if(health <= 0)
        {
            die();

        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
    }
    void die()
    {
        Debug.Log("died");
		for (int i = 0; i < thingsToEnable.Length; i++)
		{		
			thingsToEnable[i].SetActive(true);
		}
		//for (int i = 0; i < thingsToDisable.Length; i++)
		//{
		//	thingsToDisable[i-1].SetActive(false);
		//	thingsToEnable[i].SetActive(true);
		//}
	}
}
