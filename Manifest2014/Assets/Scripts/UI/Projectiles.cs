using UnityEngine;
using System.Collections;

public class Projectiles : MonoBehaviour {
	public GUISkin customGUI;
	public GameObject player;
	public GameObject projectilePrefab;
	public int numProjectiles = 10;


	// Use this for initialization
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("flyingCharacter");
		if (Input.GetKeyDown (KeyCode.Space)) 
		  shoot();
	}
	void OnGUI()
	{
		GUI.skin = customGUI;
		GUI.Label(new Rect (10, 10, 100, 100), ""+numProjectiles+"");
	}	

	void addProjectiles()
	{
		numProjectiles++;
	}

	void shoot()
	{
			Instantiate(projectilePrefab, player.transform.position, player.transform.rotation);
		    numProjectiles--;
    }
}
