﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
    Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
        }
    }
}
