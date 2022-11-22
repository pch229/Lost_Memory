using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;


public class GameManager: MonoBehaviour
{
    public Button Start_button;
    public Button Exit_button;
    public Button Menu_Button;
    public Button Quit_Button;
    public GameObject MenuPanel;
    public Button Inventory_Button;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
    
        Start_button = GetComponent<Button>();
        Start_button.onClick.AddListener(Startclick);
        Exit_button.onClick.AddListener(Exitclick);
        Exit_button = GetComponent<Button>();
        Menu_Button = GetComponent<Button>();
        Menu_Button.onClick.AddListener(Menuclick);
=======
       Startbutton = GameObject.Find("Start_bitton").GetComponent<Button>();
>>>>>>> upstream/main

    }
    public void Startclick()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Exitclick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Menuclick()
    {
        Time.timeScale = 0;
        MenuPanel.SetActive(true);
    }
    public void Continue()
    {
        Time.timeScale = 1;
        MenuPanel.SetActive(false);
    }
    public void Quit()
    {
        SceneManager.LoadScene("StartScene");
    }
    // Update is called once per frame
    void Update()
    {
     
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
