using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteAfter : MonoBehaviour {


   // public Camera MainCam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float dist = Camera.main.transform.position.y - transform.position.y;

        if (dist> 15.0f){
            Destroy(gameObject);
        }

	}
}
