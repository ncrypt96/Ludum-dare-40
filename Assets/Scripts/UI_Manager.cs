using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    // Use this for initialization
    public Text score;
    void Start () {
        score.text = PlayerPrefs.GetInt("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("score").ToString();
    }
}
