using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenusController : MonoBehaviour
{

    public GameObject StartButton;
    public GameObject ControlsButton;
    public GameObject QuitButton;

    private Button start;
    private Button controls;
    private Button quit;

    // Start is called before the first frame update
    void Start()
    {
        start = StartButton.GetComponent<Button>();
        controls = ControlsButton.GetComponent<Button>();
        quit = QuitButton.GetComponent<Button>();


        start.onClick.AddListener(onStart);
        controls.onClick.AddListener(onControls);
       quit.onClick.AddListener(onQuit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onStart()
    {
        SceneManager.LoadScene("Level1");
    }
    void onControls()
    {
        SceneManager.LoadScene("Controls");
    }
    void onQuit()
    {
        Application.Quit();
    }
}

