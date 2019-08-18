using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] enemy;
	public float timeToSpawn;
	public bool canSpawn;

	// Use this for initialization
	void Start () {

		canSpawn = false;

	}
	
	// Update is called once per frame
	void Update () {

		timeToSpawn += Time.deltaTime;

		if(timeToSpawn >= 15.0f) {

			canSpawn = true;

			if(canSpawn == true) {

				int rand = Random.Range(1,3);

				switch(rand) {

					case 1:
						canSpawn = false;
						GameObject enemyClone;
						enemyClone = Instantiate(enemy[0], transform.position, Quaternion.identity) as GameObject;
						timeToSpawn = Time.deltaTime;
					break;

					case 2:
						canSpawn = false;
						GameObject enemyClone2;
						enemyClone2 = Instantiate(enemy[1], transform.position, Quaternion.identity) as GameObject;
						timeToSpawn = Time.deltaTime;
					break;

				}

			}

		}

	}
}
