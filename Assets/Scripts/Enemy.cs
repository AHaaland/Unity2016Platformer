using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    void Update()
    {    
    
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
