using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour {

	public GameObject mine;
	public float timeToSpawn;
	public bool canSpawn;
	public float speed;
	public Animator anim;
	public bool dropmine;

	// Use this for initialization
	void Start () {

		canSpawn = false;

	}
	
	// Update is called once per frame
	void Update () {

		anim = GetComponent<Animator>();

		var x = speed * Time.deltaTime;
		transform.Translate(x,0,0);

		timeToSpawn += Time.deltaTime;

		if(timeToSpawn >= 3.0f) {

			canSpawn = true;

			if(canSpawn == true) {

				canSpawn = false;
				anim.SetBool("drop", true);
				GameObject mineClone;
				mineClone = Instantiate(mine, transform.position, Quaternion.identity) as GameObject;
				timeToSpawn = Time.deltaTime;
				//anim.SetBool("drop", false);

			}

		}

	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.gameObject.tag == "bullet") {

			Destroy(gameObject);

		}

	}

}
