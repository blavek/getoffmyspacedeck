using UnityEngine;
using System.Collections;

public class positionSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Camera.main.transform.position);
		transform.forward = -transform.forward;
	}
}
