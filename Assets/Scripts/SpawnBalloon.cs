using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    public GameObject[] balloonprefab;
    private float upbound = 6;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnballoon", 2, 7);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //balloon spawning
    void spawnballoon()
    {
        int balloonindex = Random.Range(0, balloonprefab.Length);
        Vector3 position = new Vector3(Random.Range(-1, 8), upbound, transform.position.z);
        Instantiate(balloonprefab[balloonindex], position, balloonprefab[balloonindex].transform.rotation);    
    }
}
