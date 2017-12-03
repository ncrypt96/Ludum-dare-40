using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_destroyer_child : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Waves")
        {
            StartCoroutine(Killer());
        }
    }

    IEnumerator Killer()
    {
        yield return new WaitForSeconds(2f);
        Destroy(transform.parent.gameObject);
    }
}
