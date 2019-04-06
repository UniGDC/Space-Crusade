using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponManager : MonoBehaviour
{
    public GameObject[] guns;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("button pressed");
            guns[1].SetActive(false);
            guns[0].SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("button pressed");
            guns[0].SetActive(false);
            guns[1].SetActive(true);
           
        }
    }
}
