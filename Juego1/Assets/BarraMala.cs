using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraMala : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}//Fin de start
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 150, 0) * Time.deltaTime);
	}//Fin de update
}
