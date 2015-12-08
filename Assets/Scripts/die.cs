using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	public GameObject Target;
	// Use this for initialization
	void Start () {
		transform.LookAt(Target.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Vector3.Distance(transform.position, Camera.main.transform.position) > 100)
			GameObject.Destroy (gameObject);

		if (Physics.Raycast (transform.position, Vector3.forward, out hit, 10.0f, 2)) {
			GameObject.Destroy (hit.transform.parent);
			GameObject.Destroy (gameObject);
		}
	}
}
