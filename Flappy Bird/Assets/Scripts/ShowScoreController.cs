using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowScoreController : MonoBehaviour
{
    //public GameObject instance;
   // public GameObject ScoreText;
    public Text  ShowScoretext;
    public GameObject MenuButton;
    public GameObject tutorialButton;
    public GameObject HardLevelButton;

    private Button Hard;
    private Button Tutorial;
    private Button Menu;


    // Start is called before the first frame update
    void Start()
    {
        Hard = HardLevelButton.GetComponent<Button>();
        Tutorial = tutorialButton.GetComponent<Button>();
        Menu = MenuButton.GetComponent<Button>();

        
        Hard.onClick.AddListener(onHard);
       Tutorial.onClick.AddListener(onTutorial);
        Menu.onClick.AddListener(onMenu);

        //ShowScoretext = ScoreText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
        ShowScoretext.text = "Your Score Was: " + GameController.instance.score;
    }
    void onHard()
    {
        SceneManager.LoadScene("Level2");
    }
    void onMenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
    void onTutorial()
    {
        SceneManager.LoadScene("Level1");
    }
}
