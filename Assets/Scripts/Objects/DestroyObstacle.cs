using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Destroy(gameObject,15);

	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag == "bullet") {

			Destroy(other.gameObject);
			Destroy(gameObject);

		}

	}
}
