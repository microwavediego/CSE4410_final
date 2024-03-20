using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class PlayerShoot : MonoBehaviour {
    public Transform firePoint;
    public GameObject detergentPrefab;

    void Start() {
        // this ignores collisions between player and firing detergents
        Physics.IgnoreLayerCollision(6, 7); 
    }

    // Update is called once per frame
    void Update() {
        // if we receive a mouse click, fire detergent
        if(Input.GetMouseButtonDown(0)) {
            Shoot();
        }
    }

    // firing detergents
    void Shoot() {
        GameObject detergent = Instantiate(detergentPrefab, firePoint.position, firePoint.rotation);
        DetergentMovement movement = detergent.GetComponent<DetergentMovement>();
        float direction = transform.localScale.x > 0 ? 1 : -1;
        movement.SetDirection(direction);
        
        // if detergent doesn't hit anything, destroy after 5f
        Destroy(detergent, 5f);
    }

}
