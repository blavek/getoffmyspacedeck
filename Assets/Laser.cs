using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	LineRenderer line;
	public float fireRate = 1f;
	private float timeElapsed = 1f;
	private float laserOff = .3f;
	public float fireDuration = .3f;

	// Use this for initialization
	void Start () {
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed -= Time.deltaTime;

		if(timeElapsed <= 0) {
			StopCoroutine("fireLaser");
			StartCoroutine("fireLaser");
			timeElapsed = fireRate;
		}
	}

	IEnumerator fireLaser() {
		line.enabled = true;

		while (laserOff > 0) {
			laserOff -= Time.deltaTime;
			line.renderer.material.mainTextureOffset = new Vector2(0, Time.time);
			Transform shootPosition = GameObject.FindGameObjectWithTag("Target").transform;

			Ray ray = new Ray (new Vector3(0f, 0.5f, -10f), shootPosition.forward);
			RaycastHit hit;

			line.SetPosition(0, ray.origin);

			if(Physics.Raycast(ray, out hit, 10000)) {
				Debug.Log("hit");
				line.SetPosition(1, hit.point);
				GameObject.Destroy (hit.transform.gameObject);
			} else {
				line.SetPosition(1, ray.GetPoint (10000));
			}

            yield return null;
		}

		laserOff = fireDuration;
		line.enabled = false;
	}
}
