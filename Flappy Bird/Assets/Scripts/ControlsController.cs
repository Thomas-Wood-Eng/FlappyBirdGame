using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlsController : MonoBehaviour
{
    public GameObject MainMenuButton;
    public GameObject PlayButton;

    private Button Play;
    private Button Menu;


    // Start is called before the first frame update
    void Start()
    {
        Menu = MainMenuButton.GetComponent<Button>();
        Play = PlayButton.GetComponent<Button>();

        Menu.onClick.AddListener(onMenu);
        Play.onClick.AddListener(onPlay);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    public void onMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void onPlay()
    {
        SceneManager.LoadScene("Level1");
    }
}
