using UnityEngine;
using System.Collections;

public class MainBehaviourScript : MonoBehaviour {

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//Debug.Log ("ClickOk");
			Application.LoadLevel("screan1");
		}
	}
}
