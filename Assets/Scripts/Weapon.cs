using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack()
    {
        var r = (GameObject)Instantiate(projectile,new Vector3(2,0),Quaternion.identity,transform);
        r.transform.localPosition = new Vector3(-5, 0);
        r.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.01f, 0.3f);
            player.currentWeapon = this;
        }
    }
}
