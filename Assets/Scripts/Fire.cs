using UnityEngine;
using System.Collections;

//#pragma strict
//Set up variables to get specified in Unity
public class Fire : MonoBehaviour {
	public Rigidbody Laser; //:Rigidbody;
	public Rigidbody Missile; //:Rigidbody;
	public float shootForce1; //:float;
	public float shootForce2; //:float;
	private Transform shootPosition; //:Transform;
	public float time = 1;
	private float timeElapse = 1;

	void Start() {
			shootPosition = GameObject.FindGameObjectWithTag("Target").transform;
	}

	void FixedUpdate()
	{
		timeElapse = timeElapse - Time.deltaTime;
	//	Debug.Log(time);
		//Creates a projectile whenever the player presses the left mouse button
	//		Debug.Log(shootPosition.transform.position.x);
		if(timeElapse <= 0)
		{
			//Fires Laser
			shootPosition = GameObject.FindGameObjectWithTag("Target").transform;
//			Rigidbody instanceLaser = Instantiate(Laser, Camera.main.transform.position, shootPosition.rotation) as Rigidbody;
	//		instanceLaser.transform.LookAt(shootPosition.transform.position);
			//instanceLaser.AddComponent<Rigidbody>();
//			instanceLaser.rigidbody.AddForce(transform.forward * shootForce1);
			timeElapse = time;

			Ray ray = new Ray(transform.position, shootPosition.forward);
			RaycastHit hit;

			if (Physics.Raycast (transform.position, Vector3.forward, out hit, 100000.0f, 2)) {
				Debug.Log("hit");
	//r			hit.
				GameObject.Destroy (hit.transform.parent);
//				GameObject.Destroy (gameObject);
			}
			
		}
	/*
		if(Input.GetButtonDown("Fire2")) //Fires missiles
		{
			//Fires Missile
			var instanceMissile = Instantiate(Missile, transform.position, shootPosition.rotation);
			instanceMissile.GetComponent.<Rigidbody>().AddForce(shootPosition.right * shootForce2);
		}
	*/
	}
}