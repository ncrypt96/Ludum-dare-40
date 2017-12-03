using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self_Destruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("SelfDestruction", 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SelfDestruction()
    {
        Destroy(this.gameObject);
    }
}
