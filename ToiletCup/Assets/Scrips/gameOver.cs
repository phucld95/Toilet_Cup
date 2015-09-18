using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class gameOver : MonoBehaviour {
	public Text gameO;

	// Gameover when bog OnCollision whit background2.
	void OnCollisionEnter2D (Collision2D coll){
		if(coll.gameObject.tag == "bug"){
			Time.timeScale = 0;
			gameO.text = "Game over!";
		}
	}
}
