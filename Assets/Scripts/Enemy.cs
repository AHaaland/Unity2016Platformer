using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    Vector3 direction = new Vector3(-1,-.1f);
    // Update is called once per frame
    void Update()
    {
        /* Movement type 1
        transform.position += direction * Time.deltaTime;
        if(transform.position.x <= 1.2)
        {
            direction = new Vector3(1,.1f);
        }
        if(transform.position.x >= -9)
        {
            direction = new Vector3(-1,-.1f);
        }*/
        /* Movement type 2
        transform.position = Vector3.MoveTowards(transform.position, FindObjectOfType<Player>().transform.position, Time.deltaTime);
        */
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Die();
        }
    }
}
