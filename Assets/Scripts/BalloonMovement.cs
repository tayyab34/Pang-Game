using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    private float balloonup = 8;
    private float balloondown = 2;
    private Rigidbody balloonRb;
    private float jumpforce = 5;

    // Start is called before the first frame update
    void Start()
    {
        balloonRb = GetComponent<Rigidbody>();
    }
//Balloon Movements 
    void Update()
    {
        if (transform.position.y > balloonup)
        {
            balloonRb.AddForce(Vector3.down, ForceMode.Impulse);
        }
        if (transform.position.y < balloondown)
        {

            balloonRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

        }
        balloonRb.AddForce(Vector3.down);
    }
   
}
