using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {
	public float projectileSpeed = 25.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if(this.rigidbody2D.velocity.x < maxProjectileVelocityX)
		this.rigidbody2D.velocity = (new Vector2 (projectileSpeed, 0));
	}

	void OnTriggerEnter2D(Collider2D c) {
		
		if (c.gameObject.tag == "Enemy")
			Destroy (this.gameObject); 
	}
}
