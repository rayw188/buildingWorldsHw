﻿using UnityEngine;
using System.Collections;

public class cubeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Transform> ().position += new Vector3 (0f, 1f, 0f);

	}
}
