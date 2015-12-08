using UnityEngine;
using System.Collections;

public class MissileCollision : MonoBehaviour 
{
	void OnCollisionEnter(Collision col)
	{
		//Destroy (gameObject);
		if (col.gameObject.name != "Cursor") {
			Destroy (gameObject);
		}
	}
}

