using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public float spinSpeed = 300.0f;
    public float movementSpeed = 1.0f;

    private float distance; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime); // rotation among x, y, z axis
        distance = Vector2.Distance(transform.position, player.transform.position);
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, movementSpeed * Time.deltaTime);
    }
}
