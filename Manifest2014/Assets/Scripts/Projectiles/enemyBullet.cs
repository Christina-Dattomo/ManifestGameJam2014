using UnityEngine;
using System.Collections;

public class enemyBullet : MonoBehaviour {
	public float projectileSpeed = -20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		this.rigidbody2D.velocity = (new Vector2 (projectileSpeed, 0));
	}
}
