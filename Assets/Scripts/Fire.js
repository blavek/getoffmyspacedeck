#pragma strict
//Set up variables to get specified in Unity
var Laser:Rigidbody;
var Missile:Rigidbody;
var shootForce1:float;
var shootForce2:float;
private var shootPosition:Transform;
var time:float = 1;
private var timeElapse:float = time;

function Start() {
		shootPosition = GameObject.FindGameObjectWithTag("Target").transform;
}

function Update()
{
	timeElapse = timeElapse - Time.deltaTime;
//	Debug.Log(time);
	//Creates a projectile whenever the player presses the left mouse button
//		Debug.Log(shootPosition.transform.position.x);
	if(timeElapse <= 0)
	{
		//Fires Laser
		shootPosition = GameObject.FindGameObjectWithTag("Target").transform;
		var instanceLaser : Rigidbody = Instantiate(Laser, Camera.main.transform.position, shootPosition.rotation);
//		instanceLaser.transform.LookAt(shootPosition.transform.position);
		instanceLaser.GetComponent.<Rigidbody>().AddForce(transform.forward * shootForce1);
		timeElapse = time;
	}
/*
	if(Input.GetButtonDown("Fire2")) //Fires missiles
	{
		//Fires Missile
		var instanceMissile = Instantiate(Missile, transform.position, shootPosition.rotation);
		instanceMissile.GetComponent.<Rigidbody>().AddForce(shootPosition.right * shootForce2);
	}
*/
}