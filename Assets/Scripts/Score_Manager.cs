using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour {

    // Use this for initialization
    public GameObject boat;
    float distanceTravelled = 0;
    Vector3 lastPosition;
    int score;
    

    void Awake()
    {
        
        lastPosition = boat.transform.position;
        
        PlayerPrefs.SetInt("score", 0);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        distanceTravelled += Vector3.Distance(boat.transform.position, lastPosition);
        lastPosition = boat.transform.position;
        score = (int)distanceTravelled / 3;
        PlayerPrefs.SetInt("score", score);

    }
    
}
