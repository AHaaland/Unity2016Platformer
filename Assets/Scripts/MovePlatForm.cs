using UnityEngine;
using System.Collections;

public class MovePlatForm : MonoBehaviour {
    new Rigidbody2D rigidbody2D;
    float startingY;
    public float speed = .5f;
    public float distance = 2;
    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        startingY = transform.position.y;
    }

    void FixedUpdate()
    {
        if (transform.position.y < startingY + distance)
        {
            speed *= -1;
        }
        if (transform.position.y > startingY)
        {
            speed *= -1;
        }
        var v = rigidbody2D.velocity;
        v.y = -speed;
        rigidbody2D.velocity = v;
    }
}
