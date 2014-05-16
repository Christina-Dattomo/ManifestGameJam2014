using UnityEngine;
using System.Collections;

public class CameraLock : MonoBehaviour {
	public GameObject Player;
	public Vector3 CameraOffset;
	public float ExpandSize;
	public float ExpandSpeed;
	public float CameraYOffset;
	private Vector3 PlayerPos;
	private Vector3 velocity = Vector3.zero;
	private Camera camControl;
	private float initialCamSize;

	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
		PlayerPos = Player.transform.position;
		camControl = GetComponent<Camera>();
		initialCamSize = camControl.orthographicSize;
	}
	
	void Update () {
		if(Player == null)
		{
			Player = GameObject.FindGameObjectWithTag("Player");
			PlayerPos = Player.transform.position;
		}

		//transform.position = new Vector3(Player.transform.position.x + 2, lockedYPosition, -5);
		PlayerPos = Player.transform.position;
		transform.position = new Vector3(PlayerPos.x + CameraOffset.x, CameraOffset.y, -10);
	}
	public void StartExpand()
	{
		StartCoroutine(MoveCamera());
		StartCoroutine(ExpandCamera());
	}
	IEnumerator ExpandCamera()
	{
		while(camControl.orthographicSize < ExpandSize)
		{
			camControl.orthographicSize += ExpandSpeed*Time.deltaTime;
			yield return new WaitForSeconds(0);
		}
	}
	IEnumerator MoveCamera()
	{
		while(CameraOffset.y > -ExpandSize/2 + CameraYOffset)
		{
			CameraOffset = new Vector3(CameraOffset.x, CameraOffset.y - ExpandSpeed*Time.deltaTime, -10);
			yield return new WaitForSeconds(0);
		}
	}
}
