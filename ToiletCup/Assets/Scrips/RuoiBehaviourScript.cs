using UnityEngine;
using System.Collections;


public class RuoiBehaviourScript : MonoBehaviour {
	private float speed2;
	public Vector3 speed;
	public int blood;
	private GameObject main;

	// Use this for initialization
	void Start () {
		speed = this.transform.position / 500;
		speed.z = 0;
		//Debug.Log (speed2);
		speed = speed * Random.Range(1, speed2) ;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.x < 0	&& Time.timeScale != 0){
			gameObject.transform.Translate(- speed);
		}
		if(blood == 0){
			main = GameObject.Find("main");
			//Debug.Log("Call");
			main.SendMessage("plusPoint");
			Destroy(this.gameObject, 0f);
		}
	}

	void getSpeed (float a){
		speed2 = a;
	}

	void suptractionBlood (){
		blood --;
	}
}
