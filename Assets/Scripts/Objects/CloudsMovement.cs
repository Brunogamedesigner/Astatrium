using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMovement : MonoBehaviour {

	public GameObject cloudsRespawner;
	public float speed;
	public bool canMove;

	// Use this for initialization
	void Start () {

		speed = 0.005f;
		canMove = true;

	}
	
	// Update is called once per frame
	void Update () {

		if(canMove == true) {

			transform.Translate(-speed,0,0);

		}

	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag == "destroyer") {

			transform.position = cloudsRespawner.gameObject.transform.position;

		}

	}
}
