using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour {
	//Set up values for how any hits the shield can take as well as an object that will be spawned to show the shield has been hit
	public GameObject shield;
	public int shieldStrength = 5;
	public Transform node;
	void Start(){
	}
	
	//destroys the object when its shield strength is 0
	void Update(){
		if (shieldStrength == 0) {
			Destroy(gameObject);
		}
	}
	
	//shows that the object was hit by spawning an object where the node is
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Projectile") {
			Instantiate (shield, col.transform.position, col.transform.rotation);
			shieldStrength--;
			Debug.Log(shieldStrength);
		}
	}
}
