using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{
    private float upbound = 6;
    private float speed = 5;
    public GameObject mediumballoon;
    public GameObject smallballoon;
    public Transform size;
    void Start()
    {
        
    }
    void Update()
    {
        //Fire Movement and size
        if (transform.position.y > upbound)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        size.localScale += new Vector3(0, 0.1f, 0);
    }
    //Balloon spawning when fired
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Physics.IgnoreCollision(other.GetComponent<SphereCollider>(), GetComponent<CapsuleCollider>());
        }
        else if (other.CompareTag("Balloon"))
        {
            Instantiate(mediumballoon, other.transform.position, mediumballoon.transform.rotation);
            Instantiate(mediumballoon, other.transform.position, mediumballoon.transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("mediumballoon"))
        {
            Instantiate(smallballoon, other.transform.position, smallballoon.transform.rotation);
            Instantiate(smallballoon, other.transform.position, smallballoon.transform.rotation);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("smallballoon"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
