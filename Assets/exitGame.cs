using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetButtonDown("Cancel"))
        {
            QexitGame();
        }
	}

    void QexitGame()
    {
        Application.Quit();
    }
}
