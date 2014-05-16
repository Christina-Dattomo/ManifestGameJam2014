using UnityEngine;
using System.Collections;

public class projPickup : MonoBehaviour {
	public GameObject gameManager;
	public Projectiles addProj;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager");
		addProj = gameManager.GetComponent<Projectiles>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c) {
		
		if (c.gameObject.tag == "Player") 
	        {
		     	Destroy (this.gameObject);
			    addProj.addMultipleProjectiles();
			}

	}
}
