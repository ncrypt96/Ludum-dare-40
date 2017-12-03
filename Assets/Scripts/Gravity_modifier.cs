using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_modifier : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rb2d;

    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = PlayerPrefs.GetFloat("gravity");
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
