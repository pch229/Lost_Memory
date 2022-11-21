using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;


public class GameManager: MonoBehaviour
{
    public Button Startbutton;
    public Button Click;
    // Start is called before the first frame update
    void Start()
    {
        Start_button = GameObject.Find("Start_bitton").GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
