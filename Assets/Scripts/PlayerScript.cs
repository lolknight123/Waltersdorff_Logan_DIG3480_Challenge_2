using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rd2d;

    public float speed;

    public Text score;
    public Text win;
    public Text life;
    

    private int scoreValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        score.text = "Score: " + scoreValue.ToString();
        win.text = "";
        // need to do more research on how to make an effective life system before adding enemies 
        life.text = "Lives: 3";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");
        float vertMovement = Input.GetAxis("Vertical");
        rd2d.AddForce(new Vector2(hozMovement * speed, vertMovement * speed));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.tag == "Money")
        {
            scoreValue += 1;
            score.text = "Score: " + scoreValue.ToString();
            Destroy(collision.collider.gameObject);
        }
        if (scoreValue >= 4)
        {
         win.text = "You Win! Game by Logan Waltersdorff   PRESS ESC TO QUIT";
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // this works but i need to find out how to limit the height and how to add more gravity when it reaches that height
        if (collision.collider.tag == "Ground")
        {
            if (Input.GetKey(KeyCode.W))
            {
                rd2d.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
            }
        }
    }
}
