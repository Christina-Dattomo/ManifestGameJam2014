using UnityEngine;
using System.Collections;

public class collectibleTrigger : MonoBehaviour {
	public GameObject gameManager;
	public Score scoring;
	
	void Start () 
	{
		gameManager = GameObject.Find ("GameManager");
		scoring = gameManager.GetComponent<Score>();
	}
	
	void OnTriggerEnter2D(Collider2D c) {

	 if (c.gameObject.tag == "Player")
			Destroy (this.gameObject);
			scoring.addScore(); 
		}

}
