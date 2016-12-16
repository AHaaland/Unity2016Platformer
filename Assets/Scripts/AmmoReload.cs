using UnityEngine;
using System.Collections;
public class AmmoReload : MonoBehaviour
{
    public int clipSize = 5;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            FindObjectOfType<Weapon>().ammoPickup(clipSize);
            gameObject.SetActive(false);
        }
    }
}