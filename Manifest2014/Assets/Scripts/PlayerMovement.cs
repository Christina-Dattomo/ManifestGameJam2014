using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D rigid2D;
	public float MaxVelocityX = 6.0f;
	public float AccelerationX = 12.0f;
	public float UpForce = 1.5f;
	public float GavityScale = 0.1f;

	void Start () {
		rigid2D.gravityScale = GavityScale;
	}

	void Update () 
	{
		if(rigid2D.velocity.x < MaxVelocityX)
		{
			rigid2D.AddForce(new Vector2(AccelerationX, 0));
		}
		//else 
			//rigid2D.velocity = new Vector2(3, rigid2D.velocity.y);
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			rigid2D.velocity = new Vector2(rigid2D.velocity.x, UpForce);
		}
	}
}
