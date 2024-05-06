using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GearController : MonoBehaviour
{
    [SerializeField] SettingsPopup settingsPopup;

    public Color highlightColor = Color.cyan;

    private void Start()
    {
        settingsPopup.Close();
    }

    public void OnMouseEnter()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }
    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseUp()
    {
        if (settingsPopup.IsOpen())
        {
            settingsPopup.Close();
        }
        else
        {
            settingsPopup.Open();
        }
        PauseManager.Instance.TogglePause();
    }
}
