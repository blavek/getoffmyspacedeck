using UnityEngine;
using System.Collections;

public class Ship2 : MonoBehaviour {
	/*Sets up variables to determine if the ship is destroyed, what their targets are, and how fast they are*/
	public bool die;
	public bool friend;
	public bool check1 = true;
	public bool check2;
	public bool check3;
	public GameObject target1;
	public GameObject target2;
	public GameObject target3;
	public GameObject projectile;
	public Transform node;
	public float speed = 0.2f;
	
	// Use this for initialization
	void Start () {
		//Sets business person's final destination
		target1 = GameObject.Find ("ShipMove5");
		target2 = GameObject.Find ("ShipMove4");
		target3 = GameObject.Find ("ShipMove3");
	}
	
	// Update is called once per frame
	void Update () {
		//The ship moves towards their targets and they're destroyed when they are killed by the player
		if (check1) {
			Vector3 direction = (target1.transform.position - transform.position).normalized;
			float distance = (target1.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				speed = 0f;
				/*if(Time.fixedTime % 7 == 0){
					Instantiate (projectile, node.transform.position, node.transform.rotation);
				}*/
				if(Time.fixedTime % 20 == 0){
					check1 = false;
					check2 = true;
				}
			}
		}
		if (check2) {
			speed = 0.2f;
			Vector3 direction = (target2.transform.position - transform.position).normalized;
			float distance = (target2.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				speed = 0f;
				/*if(Time.fixedTime % 7 == 0){
					Instantiate (projectile, node.transform.position, node.transform.rotation);
				}
				if(Time.fixedTime % 20 == 0){
					check2 = false;
					check3 = true;
				}*/
			}
		}
		if (check3) {
			speed = 0.2f;
			Vector3 direction = (target3.transform.position - transform.position).normalized;
			float distance = (target3.transform.position - transform.position).magnitude;
			Vector3 move = transform.position + (direction * speed);
			transform.position = move;
			if(distance < 1f){
				speed = 0f;
				/*if(Time.fixedTime % 7 == 0){
					Instantiate (projectile, node.transform.position, node.transform.rotation);
				}
				/*if(friend/*Time.fixedTime == 40*){
					check2 = true;
					check3 = false;
					friend = false;
				}*/
			}
		}
		
		if (die) {
			Destroy (gameObject);
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Attack") {
			die = true;
		} 
	}
}
