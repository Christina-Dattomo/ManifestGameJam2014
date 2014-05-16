using UnityEngine;
using System.Collections;

public class projectileTrigger : MonoBehaviour {
	public GameObject gameManager;
	public Projectiles projectiles;
	
	void Start () 
	{
		gameManager = GameObject.Find ("GameManager");
		projectiles = gameManager.GetComponent<Projectiles>();
	}
	
	void OnTriggerEnter2D(Collider2D c) {
		
		if (c.gameObject.tag == "Enemy")
			Destroy (this.gameObject);
		     //scoring.addScore(); 
	}
	
}
