using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreLabel;
    [SerializeField] TMP_Text healthLabel;
    [SerializeField] TMP_Text newGameLabel;
    private int score = 0;
    private int health = 5;

    public void IncreaseScore() {
        score++;
        scoreLabel.text = $"Score: {score}"; // updates score textbox 
    }

    public void DecreaseHealth() {
        health--;
        healthLabel.text = $"Health: {health}"; // updates health text box
        if (health <= 0) {
            PlatformPlayer pp = GameObject.Find("Player").GetComponent<PlatformPlayer>();
            pp.characterDeath(); // this calls for PlatformPlayer to destroy Player object since health is 0
            RestartGame(); // this does not restart game, just sets the caption in the function below
        }
    }

    public void RestartGame() {
        newGameLabel.text = "You're washed! Click Start to play again.";
    }
}
