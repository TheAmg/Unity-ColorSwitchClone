using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerContols : MonoBehaviour {


    public float jumpForce = 10.0f;
    [SerializeField]
    Rigidbody2D rb;


    public int points = 0;
    public SpriteRenderer sr;

    bool isGameActive = true;

    public Color colRed;
    public Color colGreen;
    public Color colBlue;
    public Color colYellow;


    public string currentCol;
    // Use this for initialization

    bool canMove = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SetDefColour();
    }
    // Update is called once per frame
    void Update () {

        if (canMove)
        {
            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * jumpForce * Time.deltaTime;
            }
        }


        if (transform.position.y < -10)
        {
            if (isGameActive)
            {
                isGameActive = false;
                canMove = false;
                Invoke("ReloadScene", 5.0f);
            }
            
        }
       

		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 9)
        {
            if (collision.tag == "Red")
            {
                sr.color = colRed;
                currentCol="Red";
            }
            else if (collision.tag == "Green")
            {
                sr.color = colGreen;
                currentCol = "Green";

            }
            else if(collision.tag == "Blue")
            {
                sr.color = colBlue;
                currentCol = "Blue";
            }
            else
            {
                sr.color = colYellow;
                currentCol = "Yellow";
            }
        }
        else
        {
            if (collision.tag == currentCol)
            {
                if (isGameActive)
                {
                    points++;
                }
                // Debug.Log("Passed");
                
               
            }
            else
            {
                //  Debug.Log("Game Over");
                canMove = false;
                isGameActive = false;
                Invoke("ReloadScene", 5.0f);

            }
        }

        
    }

    private void OnGUI()
    {   


        
        if (!isGameActive)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 150, 200, 50), "GAME OVER, SCORE :"+points);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 + 300, Screen.height - 50, 100, 30), "SCORE :" + points);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void SetDefColour()
    {
        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                currentCol = "Red";
                sr.color = colRed;
                break;

            case 1:
                currentCol = "Green";
                sr.color = colGreen;
                break;

            case 2:
                currentCol = "Blue";
                sr.color = colBlue;
                break;
            case 3:
                currentCol = "Yellow";
                sr.color = colYellow;
                break;
        }
    }
}
