using UnityEngine;
using System.Collections;

public class collectingObjects : MonoBehaviour {
	public GameObject gameManager;
	public GameObject collectible;
	public Score scoring;
	public Projectiles addProjectiles;
	
	void Start () 
	{
		gameManager = GameObject.Find ("GameManager");
		collectible = GameObject.Find ("collectible");
		scoring = gameManager.GetComponent<Score>();
		addProjectiles = gameManager.GetComponent<Projectiles>();
	}
	
	void OnTriggerEnter2D(Collider2D c) {

	switch (c.gameObject.tag) {	
		case "collectible":
				Destroy (collectible);
				scoring.addScore();
				break;
		case "projectile":
	            //
				break;
		}	   
	}
		
	
}
