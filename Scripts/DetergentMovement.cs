using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetergentMovement : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
   
    public void SetDirection(float direction)
    {
        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>(); // creating reference to EnemyHealth script
        if (enemy != null) // check if what we hit is an enemy 
        {
            enemy.TakeDamage(1); // call TakeDamage method which will reduce enemy health by 1
        }
        Destroy(gameObject); // this detroys the detergent after it hits something 
    }
}
