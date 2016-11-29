using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public int worth = 1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponentInParent<Player>();
        if (player != null)
        {
            this.gameObject.SetActive(false);
            FindObjectOfType<GM>().CoinCollection(worth);
        }
      
    }
}
