using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("SceneChange", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
