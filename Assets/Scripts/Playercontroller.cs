using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Playercontroller : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    Animator anim;

    void Start()

{

  anim = GetComponent<Animator>();

}

// Update is called once per frame

void Update()

{

     if (Input.GetKeyDown(KeyCode.D))

        {

          musicSource.clip = musicClipOne;

          musicSource.Play();

          anim.SetInteger("State", 1);

         }

     if (Input.GetKeyUp(KeyCode.D))

        {

          musicSource.Stop();

          anim.SetInteger("State", 0);

         }

     if (Input.GetKeyDown(KeyCode.W))

        {

          musicSource.clip = musicClipTwo;

          musicSource.Play();

          anim.SetInteger("State", 2);

         }

     if (Input.GetKeyUp(KeyCode.W))

        {

          musicSource.Stop();

          anim.SetInteger("State", 0);

         }
     if (Input.GetKeyDown(KeyCode.A))

        {

          musicSource.clip = musicClipOne;

          musicSource.Play();

          anim.SetInteger("State", 1);

         }

     if (Input.GetKeyUp(KeyCode.A))

        {

          musicSource.Stop();

          anim.SetInteger("State", 0);

         }
     if (Input.GetKeyDown(KeyCode.L))

        {

          musicSource.loop = true;

         }

     if (Input.GetKeyUp(KeyCode.L))

        {

          musicSource.loop = false;

        }
      
      if (Input.GetKeyDown(KeyCode.Escape)) 
        {
          Application.Quit();
        }
      

    }
  public bool facingRight = true; //Flip
 
void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if(h > 0 && !facingRight)
            Flip();
        else if(h < 0 && facingRight)
            Flip();
     }
void Flip ()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
