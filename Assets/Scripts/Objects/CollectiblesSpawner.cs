using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesSpawner : MonoBehaviour {

	public GameObject collectible;
	public float timeToSpawn;
	public bool canSpawn;

	// Use this for initialization
	void Start () {

		canSpawn = false;

	}
	
	// Update is called once per frame
	void Update () {

		timeToSpawn += Time.deltaTime;

		if(timeToSpawn >= 2.0f) {

			canSpawn = true;

			if(canSpawn == true) {

				canSpawn = false;
				GameObject collectibleClone;
				collectibleClone =  Instantiate(collectible, transform.position, Quaternion.identity) as GameObject;
				timeToSpawn = Time.deltaTime;

			}

		}

	}
}
