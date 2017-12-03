using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_on_MouseClick_Children : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && Input.GetMouseButton(0))
        {
            Destroy(this.transform.parent.gameObject);
        }
    }
}
