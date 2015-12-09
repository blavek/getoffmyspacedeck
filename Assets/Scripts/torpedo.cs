using UnityEngine;
using System.Collections;

public class torpedo : MonoBehaviour {

	//makes the torpedo look at camera
	void Start () {
		transform.LookAt(Camera.main.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
