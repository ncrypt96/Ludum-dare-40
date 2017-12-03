using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_UI_Manager : MonoBehaviour {

    public Text score;

	// Use this for initialization
	void Start () {
        
        score.text = PlayerPrefs.GetInt("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
}
