using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenManager : MonoBehaviour
{
    // reference to UI elements 
    public Image backgroundImage;
    public Text titleText;
    public GameObject leaderboardPanel;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to handle the start button click event
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
