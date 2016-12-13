using UnityEngine;
using System.Collections;

public class WayPtAchieve : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponentInParent<Player>();
        if (player != null)
        {
            Vector3 wayPosition = this.transform.position;
            FindObjectOfType<Player>().SetWayPt(wayPosition);
            GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
}
