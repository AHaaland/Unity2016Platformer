using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    public int ammoLeft = 5;
    GM manager;
    // Use this for initialization
    void Start()
    {
        manager = FindObjectOfType<GM>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Attack()
    {
        if (ammoLeft > 0)
        {
            var r = (GameObject)Instantiate(projectile);
            r.transform.parent = transform;
            r.transform.localScale = new Vector3(1, 1);
            r.transform.localPosition = new Vector3(-5, 0);
            r.transform.localRotation = new Quaternion();
            r.GetComponent<Rigidbody2D>().AddForce(r.transform.TransformDirection(new Vector2(-2000, 0)));
            r.transform.parent = null;
            ammoLeft--;
            manager.updateTextAmmo(ammoLeft);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        manager.updateTextAmmo(ammoLeft);
        var player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            player.currentWeapon = this;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.01f, 0.35f);        
        }
    }
    public void ammoPickup(int pickupSize)
    {
        ammoLeft += pickupSize;
        manager.updateTextAmmo(ammoLeft);
    }
}
