using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {
	public GUISkin customGUI;
	public GameObject player;
	public GameObject projectilePrefab;
	//public GameObject rapidFireObj;
	//public RapidfirePowerup rapidFireTrig;
	public int numProjectiles = 10;
	public float shotCooldown = 1f;
	public bool canShoot = true;

	void Start()
	{
		//rapidFireObj = GameObject.Find ("Rapidfire");
		//rapidFireTrig = rapidFireObj.GetComponent<RapidfirePowerup>();
	}
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("flyingCharacter");

		if (Input.GetKeyDown (KeyCode.Space)) 
			StartCoroutine ("shoot");
	}

	void OnGUI()
	{
		GUI.skin = customGUI;
		GUI.Label(new Rect (10, 10, 400, 100), "Arrows:"+numProjectiles+"");
	}	

	public void addProjectiles()
	{
		numProjectiles++;
	}

	public void addMultipleProjectiles()
	{
		numProjectiles = numProjectiles + 6;
	}

	IEnumerator shoot()
	{
		if (numProjectiles >= 1 && canShoot) 
		{
			Instantiate (projectilePrefab, player.transform.position, player.transform.rotation);
			numProjectiles--;
			canShoot = false;
			yield return new WaitForSeconds (shotCooldown);
			canShoot = true;
		} 

//		if (rapidFireTrig.rapidFireActivate == true)
//		{
//			Instantiate (projectilePrefab, player.transform.position, player.transform.rotation);
//			yield return new WaitForSeconds (rapidCooldown);
//		}
		
	}


}
