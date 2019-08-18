using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCountText : MonoBehaviour {

	GUIText coinText;
	public GameObject player;
	public int currentCoins;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		currentCoins = player.gameObject.GetComponent<PlayerController>().coins;
		coinText.text = "x " + currentCoins;

	}
}
