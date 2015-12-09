using UnityEngine;
using System.Collections;

public class AttackCollisions : MonoBehaviour {
	//Destroys the object assuming it doesn't collide with a ship or projectile
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag != "Ship" || col.gameObject.tag != "Projectile") {
			Destroy(gameObject);
		} 
	}
}
