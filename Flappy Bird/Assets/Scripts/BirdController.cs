using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    private Rigidbody2D birdRB;
    public float UpForce;

    private Animator birdAnimator;
    public GameObject PointSound;
    public GameObject DeathSound;

    private AudioSource Ow;
    private AudioSource Point;

    



    // Start is called before the first frame update
    void Start()
    {
        birdRB = GetComponent<Rigidbody2D>();
        birdAnimator = GetComponent<Animator>();

        Ow = DeathSound.GetComponent<AudioSource>();
        Point = PointSound.GetComponent<AudioSource>();

        //put in the audio clips into the bird
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.lives <= 0)
        {
            birdAnimator.SetTrigger("Dead");

        }
        //if you push down the button and you are not dead
        if (Input.GetMouseButtonDown(0) && GameController.instance.isDead == false)
        {
            //set the velocity to 0
            birdRB.velocity = new Vector2(0, 0);
            //go up the UpForce amount
            Vector2 pushUp = new Vector2(0, UpForce);
            birdRB.AddForce(pushUp);
            //do the animation
            birdAnimator.SetTrigger("Flap");
        }

        //if you click the mouse and are dead
        if (Input.GetMouseButtonDown(0) && GameController.instance.isDead == true)
        {
            {
                //reset the game to level 1
                birdRB.position = new Vector3(2.5f, 0f);
                GameController.instance.isDead = false;
                //GameController.instance.isDead = false;
                Time.timeScale = 1;


            }
            

           

        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
        birdRB.position = new Vector3(Mathf.Clamp(birdRB.position.x, -8f, 8f), Mathf.Clamp(birdRB.position.y, -4.6f, 4.6f),0);

    }
        //if you hit the ground or the floor
        void OnCollisionEnter2D(Collision2D collision)
        {
            //kill the bird

            //birdAnimator.SetTrigger("Dead");
            //pauses the game


            Ow.Play();
            GameController.instance.Died();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            //if what is hit is the pipes
            if (other.gameObject.CompareTag("Score"))
            {
                //Add score
                Debug.Log("I got a point");
                GameController.instance.AddScore();
                Point.Play();
            }
        }

    }

