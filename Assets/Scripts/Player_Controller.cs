using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rb2d;
    public float speed;
    public float upspeed;
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*Time.deltaTime, 0f, 0f, Space.World);
           

        }else if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        }

        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, upspeed * Time.deltaTime, 0f, Space.World);

        }else if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, -upspeed * Time.deltaTime, 0f, Space.World);
        }

    }
}
