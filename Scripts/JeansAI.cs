using UnityEngine;

public class JeansAI : MonoBehaviour
{
    public float spinSpeed = 300.0f;
    public float movementSpeed = 5.0f;
    private bool movingUp = true;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime); // Keep spinning

        float screenHeight = Screen.height; // Get screen height
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position); // Convert enemy position to screen position

        if (movingUp)
        {
            if (screenPos.y >= screenHeight) movingUp = false; // Change direction if at top edge
        }
        else
        {
            if (screenPos.y <= 0) movingUp = true; // Change direction if at bottom edge
        }

        MoveVertical();
    }

    void MoveVertical()
    {
        if (movingUp)
            transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        else
            transform.position += Vector3.down * movementSpeed * Time.deltaTime;
    }
}