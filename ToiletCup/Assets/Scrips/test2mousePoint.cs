using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test2mousePoint : MonoBehaviour {
	private Vector3 target;
	public GameObject plap;
	public GameObject ruoi;
	public GameObject muoi1;
	public GameObject muoi2;
	public GameObject gian1;
	public GameObject gian2;
	private  GameObject[] A;


	public float speed;
	public Text scoreText;
	private int max;
	private int now;
	private int rand;
	private int score;


	// Use this for initialization
	void Start () {
		max = 8;
		now = 0;
		score = 0;
		SetCountText ();
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		// Creat Goj plap when chick in scream.
		speed = 1 + score / 25;
		max = 8 + score /10;
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0) {
			target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = -2f;
			Instantiate(plap, target, Quaternion.identity);
		}

		// Replay game(Click on scream).
		if (Input.GetMouseButtonDown (0) && Time.timeScale == 0) {
			Time.timeScale = 1;
			Application.LoadLevel("screan1");
		}

		// Bont Gbj bog.
		if (now < max) {
			sinht();
			now++;
		}
		SetCountText ();
	}

	// Set text score in game play.
	void SetCountText (){
		scoreText.text = "Score: " + score.ToString ();
	}

	// Plus point.
	void plusPoint(){
		score = score + 1;
		now = now - 1;
	}
	
	// Bont bog.
	void sinht(){
		rand = Random.Range(0,5);
		//Debug.Log ("rand = " + rand);
		//Debug.Log ("now = "+ now);
		if(rand == 1){
			Instantiate(ruoi, new Vector3(Random.Range(-9f, -2f), -5.39f, -2), Quaternion.identity);
		}
		if(rand == 2){
			Instantiate(muoi1, new Vector3(Random.Range(2f,9f), -5.39f, -2), Quaternion.identity);
		}
		if (rand == 3) {
			Instantiate(muoi2, new Vector3(Random.Range(-9f,-3f), 5.94f, -2), Quaternion.identity);
		}
		if (rand == 4) {
			Instantiate(gian1, new Vector3(Random.Range(1.2f,8f), 5.94f, -2), Quaternion.identity);
		}
		if (rand == 0) {
			Instantiate(gian2, new Vector3(-3.8f, Random.Range(0.7f,3.5f), -2), Quaternion.identity);
		}
		A = GameObject.FindGameObjectsWithTag ("bug");
		foreach(GameObject temp in A){
			temp.SendMessage ("getSpeed", speed);
		}
	}
}