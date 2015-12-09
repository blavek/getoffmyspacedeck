using UnityEngine;
using System.Collections;

public class ShieldAppears : MonoBehaviour {
	//destorys the object after 0.25 seconds
	void Start () {
		Destroy (gameObject, 0.25f);
	}
}
