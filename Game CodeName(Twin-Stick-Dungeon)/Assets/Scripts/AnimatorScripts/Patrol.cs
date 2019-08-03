using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;

    public Transform[] moveSpots;
    private int randomSpot;
    private float waitTime;
    public float starWaitTime;

    private void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);

    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position,moveSpots[randomSpot].position) < 0.2)
        {
            randomSpot = Random.Range(0, moveSpots.Length);
            waitTime = starWaitTime;
        }
        else
        {
            waitTime -= Time.deltaTime;
        }

    } 
}
