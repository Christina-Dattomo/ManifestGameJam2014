using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	public GameObject gameManager;
	public Score scoring;


	void Start () {
		gameManager = GameObject.Find ("GameManager");
		scoring = gameManager.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c) {
		
		if (c.gameObject.tag == "projectile") 
		{
			scoring.addScore();
			Destroy (this.gameObject);
		}
		
	}
}
