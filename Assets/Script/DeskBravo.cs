﻿using UnityEngine;
using System.Collections;

public class DeskBravo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == GameObject.Find("PaperPlane"))
        {
            GameState.instance.Bravo();
        }
    }
}
