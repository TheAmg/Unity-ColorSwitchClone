using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {



    public float rotationSpeed = 100.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // transform.Rotate(0, 0, rotationSpeed*Time.deltaTime);

        transform.RotateAround(transform.position, Vector3.back, rotationSpeed * Time.deltaTime);

	}
}
