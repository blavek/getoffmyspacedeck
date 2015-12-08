using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	/*Sets up variables to determine if the projectile is destroyed, what their target is, and how fast they are*/
	public bool die;
	public GameObject target;
	public float speed = 0.1f;
	
	// Use this for initialization
	void Start () {
		//Sets business person's final destination
		target = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		//The projectile moves towards the target and they're destroyed when they reach the target
		Vector3 direction = (target.transform.position - transform.position).normalized;
		float distance = (target.transform.position - transform.position).magnitude;
		Vector3 move = transform.position + (direction * speed);
		transform.position = move;
		
		if (distance < 1f) {
			die = true;
		}
		
		if (die) {
			Destroy (gameObject);
		}
	}
}
