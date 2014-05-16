﻿using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {
	public GameObject Player;
	//public float lockedYPosition = 0;

	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
		if(Player == null)
			Player = GameObject.FindGameObjectWithTag("Player");

		//transform.position = new Vector3(Player.transform.position.x + 2, lockedYPosition, -5);
		transform.position = new Vector3(Player.transform.position.x + 2, Player.transform.position.y, -2);
	}
}
