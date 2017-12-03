using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour {

    // Use this for initialization
    public GameObject[] enemies;
    int rate;
  

    

    void Start () {
      
        InvokeRepeating("enemySpawn", 2f, 2f);
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void enemySpawn()
    {
       Instantiate(enemies[(int)(Random.Range(0f, 5f))], new Vector3(Random.Range(-7.5f, 7.5f), 5.67f, 0f), Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
        
        
    }

    

}
