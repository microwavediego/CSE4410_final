using UnityEngine;

public class ShirtAI : MonoBehaviour
{
    public float spinSpeed = 300.0f;
    public float movementSpeed = 5.0f;
    private bool movingRight = true;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime); // Keep spinning

        // Convert viewport positions to world points
        Vector3 leftScreenEdge = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, transform.position.z - Camera.main.transform.position.z));
        Vector3 rightScreenEdge = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, transform.position.z - Camera.main.transform.position.z));

        // Move and check for direction change
        if (movingRight)
        {
            if (transform.position.x >= rightScreenEdge.x)
            {
                movingRight = false; // Change direction if at right edge
            }
        }
        else
        {
            if (transform.position.x <= leftScreenEdge.x)
            {
                movingRight = true; // Change direction if at left edge
            }
        }

        MoveHorizontal();
    }

    void MoveHorizontal()
    {
        if (movingRight)
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        else
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }
}