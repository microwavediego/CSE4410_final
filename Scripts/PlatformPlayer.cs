using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayer : MonoBehaviour {
    public float speed = 4.5f;
    public float jumpForce = 12.0f;

    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D box;

    private void Start() {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }

    private void Update() {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        Vector2 movement = new Vector2(deltaX, body.velocity.y);
        body.velocity = movement;

        Vector3 max = box.bounds.max;
        Vector3 min = box.bounds.min;
        Vector2 corner1 = new Vector2(max.x, min.y - 0.1f);
        Vector2 corner2 = new Vector2(min.x, min.y - 0.2f);
        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        bool grounded = hit != false;

        anim.SetFloat("speed", Mathf.Abs(deltaX));
        if(!Mathf.Approximately(deltaX, 0)) {
            transform.localScale = new Vector3(Mathf.Sign(deltaX), 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded) {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Enemy")) { // our enemies have an "Enemy" tag. checking if we collide with one
            Destroy(collision.gameObject); // if we collide with enemy, destroy it 
            BoxController sc = GameObject.Find("BoxController").GetComponent<BoxController>(); // creating reference to ScoreCounter
            sc.DecreaseHealth(); // calling function to decrease our player health by 1
        } 
    }

    public void characterDeath() { 
        Destroy(gameObject);
    }
}
