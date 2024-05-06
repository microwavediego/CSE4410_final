using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    public void OnMouseDown()
    {
        Debug.Log("Changing scene");
        PauseManager.Instance.TogglePause();
        SceneManager.LoadScene("MainMenu");
    }
}
