using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{

    public float speed = 1.19f;
    public Transform pointA;
    public Transform pointB;

    float time;

    void Start()
    {

    }

    void Update()
    {
        //PingPong between 0 and 1
        time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA.position, pointB.position, time);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }

    
}
