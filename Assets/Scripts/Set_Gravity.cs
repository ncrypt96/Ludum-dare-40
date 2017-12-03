using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetFloat("gravity", 1f);
        InvokeRepeating("GravityIncreaser", 2f, 2f);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void GravityIncreaser()
    {
        PlayerPrefs.SetFloat("gravity", PlayerPrefs.GetFloat("gravity") + 1f);
    }
}
