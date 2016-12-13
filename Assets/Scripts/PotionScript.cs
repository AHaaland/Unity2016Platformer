﻿using UnityEngine;
using System.Collections;

public class PotionScript : MonoBehaviour {

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
            FindObjectOfType<GM>().potionTrigger();
            gameObject.SetActive(false);
        }
    }
}