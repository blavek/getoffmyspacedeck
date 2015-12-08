using UnityEngine;
using System.Collections;

public class ShipSpawn : MonoBehaviour {
	//Sets up an ID for each individual spawn, information based on the array, where the food stand spawns from, and the foodstand object
	public int spawnID;
	public int numShips;
	public int maxShips = 5;
	public Transform[] node;
	public GameObject ship1;
	public GameObject ship2;
	
	// Use this for initialization
	void Start () {
		/*//Array holds spawn times
		int[] ID = {1,2,3,4,5,6};
		
		//For loop randomizes the contents of the array
		for (int i = 0; i < ID.Length; i++) {
			int temp = ID[i];
			int randomIndex = Random.Range(i, ID.Length);
			ID[i] = ID[randomIndex];
			ID[randomIndex] = temp;
		}
		
		//Each spawn point will get a value based on the contents of the array at the spawn's ID number
		spawnPoint = ID [spawnID-1];*/
	}
	
	// Update is called once per frame
	void Update () {
		//Spawns the ships depending on how long the game has been going for
		if (numShips < maxShips) {
			if (spawnID == 1) {
				if(Time.fixedTime % 10 == 0 && Time.fixedTime != 0/*|| Time.fixedTime == 30 || Time.fixedTime == 50*/){
					Instantiate(ship1,node[0].transform.position,node[0].transform.rotation);
					numShips++;
				}
			}
			else if (spawnID == 2) {
				if(Time.fixedTime % 20 == 0 && Time.fixedTime != 0/*|| Time.fixedTime == 40*/){
					Instantiate(ship2,node[1].transform.position,node[1].transform.rotation);
					numShips++;
				}
			}
		}
	}
}
