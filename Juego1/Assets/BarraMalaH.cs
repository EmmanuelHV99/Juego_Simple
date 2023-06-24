using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraMalaH : MonoBehaviour {
	int cont=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(cont<=75){
			transform.Translate(new Vector3(0,0,-5)*Time.deltaTime);
			cont++;
		}
		if(cont>75){
			transform.Translate(new Vector3(0,0,5)*Time.deltaTime);
			cont++;
			if(cont>=150){
				cont=0;
			}
		}
		
	}
}
