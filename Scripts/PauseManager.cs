using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private static PauseManager instance;
    public static PauseManager Instance => instance;

    private bool isPaused = false;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    private void Update()
    {
        // Add any additional input handling here if needed
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // Pause or resume the game
    }
}