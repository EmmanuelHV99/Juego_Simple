﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (50, 200, 125) * Time.deltaTime);
	}
}
