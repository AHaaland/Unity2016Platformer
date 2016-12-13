using UnityEngine;
using System.Collections;

public class EndPoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D collision)
	{
		var player = collision.gameObject.GetComponentInParent<Player>();
		if(player != null)
		{
            GM test = FindObjectOfType<GM>();
            Debug.Log(test);
            test.winner();
			gameObject.SetActive(false);
		}
	}
}
