using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    public GameObject fireprefab;
    public float speed = 10;
    private float rightbound = 7;
    private float leftbound = 3;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //player Movement and boundary
        if (transform.position.x > rightbound)
        {
            transform.position = new Vector3(rightbound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -leftbound)
        {
            transform.position = new Vector3(-leftbound, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Fire spawn
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fireprefab,transform.position, fireprefab.transform.rotation);
        }
    }
    //player destroy with balloon
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            Physics.IgnoreCollision(other.GetComponent<CapsuleCollider>(), GetComponent<SphereCollider>());
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
