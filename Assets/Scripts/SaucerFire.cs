using UnityEngine;
using System.Collections;

public class SaucerFire : MonoBehaviour {
	//Sets up the projectile that the saucer fires and where it comes from
	public GameObject projectile;
	public Transform[] node;
	public int barrelID = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.fixedTime % 5 == 0) {
			Instantiate(projectile,node[barrelID].transform.position,node[barrelID].transform.rotation);
			barrelID++;
			if(barrelID > 1){
				barrelID = 0;
			}
		}
	}
}
