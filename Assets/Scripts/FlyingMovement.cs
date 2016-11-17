using UnityEngine;
using System.Collections;

public class FlyingMovement : MonoBehaviour
{
    public Vector3[] waypoints;
    private int waypointindex = 0;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointindex], Time.deltaTime);
        if (Vector3.Distance(transform.position, waypoints[waypointindex]) < .2f)
        {
            waypointindex++;
            waypointindex = waypointindex % waypoints.Length;
        }
    }
}
