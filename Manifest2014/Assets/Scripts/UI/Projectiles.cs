using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {
	public int numProjectiles = 10;


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void addProjectiles()
	{
		numProjectiles++;
	}

	void shoot()
	{
		//keydown instantiate projectile and shoot it
		numProjectiles--;
	}
}
