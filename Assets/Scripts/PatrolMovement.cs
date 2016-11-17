using UnityEngine;
using System.Collections;

public class PatrolMovement : MonoBehaviour
{
    Vector3 direction = new Vector3(-1, -.1f);

    void Update()
    {
        transform.position += direction * Time.deltaTime;
        if (transform.position.x <= 1.2)
        {
            direction = new Vector3(1, .1f);
        }
        if (transform.position.x >= -9)
        {
            direction = new Vector3(-1, -.1f);
        }

    }
}
