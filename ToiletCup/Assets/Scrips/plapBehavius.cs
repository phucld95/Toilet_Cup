using UnityEngine;
using System.Collections;


public class plapBehavius : MonoBehaviour {
	// Update is called once per frame
	AudioSource temp;
	public AudioClip sound;

	void Awake () {
		temp = GetComponent<AudioSource>();
		temp.PlayOneShot (sound, 0.7f);

	}

	void Update () {
		Destroy (this.gameObject, 0.25f);
	}

	// If On Trigger GameOblect bug.
	void OnTriggerEnter2D(Collider2D coll) {
		if(coll.gameObject.tag == "bug"){
			coll.gameObject.SendMessage("suptractionBlood");
		}
	}
}
