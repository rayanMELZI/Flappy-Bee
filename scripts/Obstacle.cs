using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float dificulty ;

    void Start()
    {
        transform.position = new Vector3( 14 , Random.Range(-2.5f , 2.5f) , 0 );
    }

    void FixedUpdate()
    {

        if (GameController.gameIsRuning == true)
        {
            transform.position += new Vector3( -dificulty * Time.fixedDeltaTime , 0 , 0 );
        } 
        var position = this.transform.position;
        if (position.x <= -14)
        {
            Destroy(gameObject);
        }
    }
}
