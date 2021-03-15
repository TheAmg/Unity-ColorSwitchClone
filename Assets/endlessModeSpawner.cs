using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessModeSpawner : MonoBehaviour {

    public GameObject[] spawnnableObjects;
    public Transform firstObj;
    public GameObject lastObj;
    public GameObject currentObj;
    public GameObject nextObj;


    bool canInvoke = true;
	// Use this for initialization
	void Start () {
        currentObj = firstObj.gameObject;
        lastObj = currentObj;
        nextObj = null;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (canInvoke)
        {
            canInvoke = false;
            Invoke("SpawnNext", 1.5f);
        }
		
	}

    void SpawnNext()
    {
        int index = Random.Range(0, spawnnableObjects.Length);
       // currentObj = lastObj;
        nextObj = (GameObject)Instantiate(spawnnableObjects[index], new Vector3(currentObj.transform.position.x, currentObj.transform.position.y + 6, currentObj.transform.position.z), currentObj.transform.rotation);
        lastObj = currentObj;
        currentObj = nextObj;
        canInvoke = true;
    }
    
}
