using UnityEngine;
using System.Collections;

public class ProjectileSpawn : MonoBehaviour {
	public int SpawnID;
	public int randTime;
	public int minRange = 5;
	public int maxRange = 20;
	public GameObject Projectile;
	public Transform[] node;
	
	
	// Use this for initialization
	void Start () {
		randTime = Random.Range (minRange, maxRange);
	}
	
	// Update is called once per frame
	void Update () {
		//int randint = Random.Range (1, 4);
		if (Time.fixedTime % randTime == 0 && Time.fixedTime != 0) {
			Instantiate(Projectile,node[SpawnID - 1].transform.position,node[SpawnID - 1].transform.rotation);
			randTime = Random.Range (minRange, maxRange);
		}
	}
}
