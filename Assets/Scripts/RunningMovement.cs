using UnityEngine;
using System.Collections;

public class RunningMovement : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;
    float startingX;

    public float speed = .5f;
    public float distance = 2;
    // Use this for initialization
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startingX = transform.position.x;
    }


    void FixedUpdate()
    {
        if(transform.position.x < startingX-distance)
        {
            speed *= -1;
        }
        if(transform.position.x > startingX)
        {
            speed *= -1;
        }
        var v = rigidbody2D.velocity;
        v.x = -speed;
        rigidbody2D.velocity = v;
    }
}
