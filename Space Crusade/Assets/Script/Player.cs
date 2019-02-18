using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
