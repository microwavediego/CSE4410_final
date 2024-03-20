using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButton : MonoBehaviour
{
    public Color highlightColor = Color.cyan;

    public void OnMouseEnter() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) {
            sprite.color = highlightColor;
        }
    }
    public void OnMouseExit() {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null) {
            sprite.color = Color.white;
        }
    }
    public void OnMouseDown() {
        transform.localScale = Vector3.one * 1.1f;
    }
    public void OnMouseUp() {
        transform.localScale = Vector3.one;
        SceneManager.LoadScene("SampleScene");
    }
}
