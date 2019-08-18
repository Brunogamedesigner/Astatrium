using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	public float jumpForce;
	public float floatingForce;
	public float fuel;
	public float maxFuel;
	public bool isGrounded;
	public int coins;
	private Rigidbody2D s_RigidBody2D;

	private void Awake() {

		s_RigidBody2D = GetComponent<Rigidbody2D>();
		maxFuel = 20;
		fuel = 20;
		coins = 0;
		//isGrounded = true;

	}

	// Update is called once per frame
	void Update () {

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0,y,0);
		transform.Translate(x,0,0);

		if(isGrounded == false) {

			s_RigidBody2D.constraints = RigidbodyConstraints2D.FreezeRotation;

		} else {

			s_RigidBody2D.constraints = RigidbodyConstraints2D.None;

		}

	}

	void FixedUpdate() {

		//Pulo
		if(Input.GetButtonUp("Jump") && isGrounded == true) {

			s_RigidBody2D.AddForce(new Vector2(0f, jumpForce));
			isGrounded = false;

		}

		//Flutuação: diminui o combustível do jogador a cada segundo que está no ar e segurando o pulo. 
		//Aumenta a cada segundo em contato com a água

		bool propulsorActive = Input.GetButton("Jump");

		if(propulsorActive) {

			//if(fuel > 0 && isGrounded == false) {

				s_RigidBody2D.AddForce(new Vector2(0,floatingForce));
				fuel -=50*Time.deltaTime;
				print(fuel);

			//} 

		}

		if(fuel < 0) {

			//s_RigidBody2D.AddForce(new Vector2(0,0));
			//propulsorActive = false;
			floatingForce = 0;

		} else {

			floatingForce = 20;

		}

		if (fuel < maxFuel && isGrounded == true) {

			fuel += 50 * Time.deltaTime;
			print(fuel);

		}

	}

	//Checa a colisão com a água para aumentar ou diminuir o combustível
	void OnCollisionStay2D(Collision2D other) {

		if(other.gameObject.tag == "water") {

			isGrounded = true;

		} else {

			isGrounded = false;

		}

	}

	void OnCollisionEnter2D(Collision2D other) {

		if(other.gameObject.tag == "obstacle") {

			SceneManager.LoadScene("waveGeneration");

		}

		if(other.gameObject.tag == "coins") {

			coins = coins + 1;
			print(coins);
			Destroy(other.gameObject);

		}

	}

	void OnTriggerEnter2D(Collider2D other) {

		//if(other.gameObject.tag == "coins") {

			//coins = coins + 1;
			//Destroy(other.gameObject);

		//}

		if(other.gameObject.tag == "destroyerground") {

			SceneManager.LoadScene("waveGeneration");

		}

	}

}
