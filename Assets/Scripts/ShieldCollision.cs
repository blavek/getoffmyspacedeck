using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour {
	public GameObject shield;
	public int shieldStrength = 5;
	public Transform node;
	void Start(){
	}

	void Update(){
		if (shieldStrength == 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Projectile") {
			//Debug.Log(shieldStrength);
			Instantiate (shield, node.transform.position, node.transform.rotation);
			shieldStrength--;
			Debug.Log(shieldStrength);
		}
	}
}
