using UnityEngine;
using System.Collections;

public class ShieldAppears : MonoBehaviour {
	/*public GameObject shield;
	public Transform node;*/
	void Start () {
		Destroy (gameObject, 0.25f);
	}
}
