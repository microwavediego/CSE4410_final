using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;
 
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // creating reference to BoxController script
            BoxController sc = GameObject.Find("BoxController").GetComponent<BoxController>();
            // calling method which increases score on display 
            sc.IncreaseScore();
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject); // destroys enemy since they have been hit 
    }
}
