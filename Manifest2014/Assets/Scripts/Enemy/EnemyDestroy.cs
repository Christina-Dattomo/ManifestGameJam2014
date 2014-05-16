using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	public GameObject gameManager;
	public Score scoring;
	public AudioSource playerAudio;
	public AudioClip balloonPop;


	void Start () {
		gameManager = GameObject.Find ("GameManager");
		playerAudio = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
		scoring = gameManager.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D c) {
		
		if (c.gameObject.tag == "projectile") 
		{
			scoring.addScore();
			playerAudio.PlayOneShot(balloonPop);
			if(!playerAudio.isPlaying)
				Destroy (this.gameObject);
		}
	}
}
