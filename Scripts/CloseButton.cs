using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public SettingsPopup settingsPopup;

    private void OnMouseDown()
    {
        if(settingsPopup != null)
        {
            settingsPopup.Close();
            Debug.Log("closing menu");
            PauseManager.Instance.TogglePause();
        }
    }
}
