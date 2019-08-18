using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public GameObject Bullet;

	float cooldown;

	// Use this for initialization
	void Start () {

		cooldown = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.X) && (Time.time - cooldown) >= 0.1f) {

			cooldown = Time.time;

			GameObject bulletclone;
			//bulletclone = Instantiate(Bullet, new Vector2(Cannon.gameObject.transform.position.x, Cannon.gameObject.transform.position.y), Quaternion.identity) as GameObject;
			bulletclone = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
			//bulletclone.GetComponent<BulletMovement>().speed = 0.3f;
			bulletclone.GetComponent<Rigidbody2D>().velocity = bulletclone.transform.right*15;
			Destroy(bulletclone, 3.5f);

		}

	}
}
