using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fly : MonoBehaviour
{
[SerializeField] private float force ;
[SerializeField] private float gravity ;

private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        
        //applying garvity
        rb.velocity += new Vector2(rb.velocity.x , -gravity * Time.fixedDeltaTime) ;
        
        //jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, force);
        }

        // colliding with ground and celling
        var position = this.transform.position;
        if (position.y >= 4.5 || position.y <= -4.5)
        {
            Destroy(gameObject);
            GameController.gameIsRuning = false;            
        }
    }

    // colliding with pipes (obstacles)
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
        GameController.gameIsRuning = false;
    }

}