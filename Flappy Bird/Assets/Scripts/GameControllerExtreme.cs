using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerExtreme : MonoBehaviour
{
    public static GameControllerExtreme instance;
    public static float scrollSpeed = -2.5f;

    public int score = 0;
    public Text scoreText;
    public Text LivesText;
    public bool isDead = false;
    private float deadCount = 0;
    public int lives = 3;
    private Animator birdAnimator;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }



    // Start is called before the first frame update
    void Start()
    {

    }
    public void Died()
    {
        isDead = true;
        lives = lives - 1;
        LivesText.text = "Lives: " + lives;
        if (lives <= 0)
        {
            deadCount += Time.deltaTime;
            SceneManager.LoadScene("Show Score");



        }

    }
    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {

            deadCount += Time.deltaTime;
            if (deadCount >= 2.0f)
            {
                Time.timeScale = 0;
                deadCount = 0;


            }
        }

    }
    public void AddScore()
    {
        score++;
        
        scoreText.text = "Score: " + score;

    }

}

