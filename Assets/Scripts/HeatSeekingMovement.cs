using UnityEngine;
using System.Collections;

public class HeatSeekingMovement : MonoBehaviour
{
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Player>().transform.position, Time.deltaTime);

    }
}
