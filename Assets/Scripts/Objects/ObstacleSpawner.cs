using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] obstacle;
	public float timeToSpawn;
	public bool canSpawn;

	// Use this for initialization
	void Start () {

		canSpawn = false;

	}
	
	// Update is called once per frame
	void Update () {

		timeToSpawn += Time.deltaTime;

		if(timeToSpawn >= 3.0f) {

			canSpawn = true;

			if(canSpawn == true) {

				int rand = Random.Range(1,4);

				switch(rand) {

				case 1:
					canSpawn = false;
					GameObject obstacleClone;
					obstacleClone = Instantiate(obstacle[0], transform.position, Quaternion.identity) as GameObject;
					timeToSpawn = Time.deltaTime;
					break;

				case 2:
					canSpawn = false;
					GameObject obstacleClone2;
					obstacleClone2 = Instantiate(obstacle[1], transform.position, Quaternion.identity) as GameObject;
					timeToSpawn = Time.deltaTime;
					break;

				case 3:
					canSpawn = false;
					GameObject obstacleClone3;
					obstacleClone3 = Instantiate(obstacle[2], transform.position, Quaternion.identity) as GameObject;
					timeToSpawn = Time.deltaTime;
					break;

				}

			}

		}

	}

}
