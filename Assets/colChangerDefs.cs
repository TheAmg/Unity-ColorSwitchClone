using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colChangerDefs : MonoBehaviour {

   public string currentColour;

    public Color red;
    public Color green;
    public Color blue;
    public Color yellow;

    [SerializeField]
    private SpriteRenderer spr;

	// Use this for initialization
	void Start () {
        setCol();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void setCol()
    {
        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                transform.tag = "Red";
                spr.color = red;
                break;
            case 1:
                transform.tag = "Green";
                spr.color = green;
                break;
            case 2:
                transform.tag = "Blue";
                spr.color = blue;
                break;
            case 3:
                transform.tag = "Yellow";
                spr.color = yellow;
                break;
        }
    }
}
