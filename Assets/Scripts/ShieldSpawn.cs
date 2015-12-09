using UnityEngine;
using System.Collections;

public class ShieldSpawn : MonoBehaviour {
	//sets up how any times a shield will be spawned as well as what and where 
	public int shieldStrength = 5;
	public bool spawn = true;
	public GameObject shield;
	public Transform node;
	// Use this for initialization
	void Start () {
		//creates shield
		Instantiate(shield,node.transform.position,node.transform.rotation);
		shieldStrength--;
	}
	
	// Update is called once per frame
	void Update () {


		/*if (spawn) {
			Instantiate(shield,node.transform.position,node.transform.rotation);
			shieldStrength--;
			spawn = false;
		}*/
	}

	/*void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag != "Shield") {
			spawn = true;
		} 
	}*/
}
