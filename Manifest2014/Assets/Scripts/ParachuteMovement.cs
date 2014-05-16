using UnityEngine;
using System.Collections;

public class ParachuteMovement : MonoBehaviour {

	public Rigidbody2D rigid2D = null;
	public float FallSpeed = 4.0f;
	public float HorizontalSpeed = 1.5f;
	public float HorizontalAcceleration = 1;
	// Use this for initialization
	void Start () {
		rigid2D.gravityScale = 0;
		rigid2D.velocity = new Vector2(0, -FallSpeed);
	}

	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			if(rigid2D.velocity.x > -HorizontalSpeed)
			{
				rigid2D.AddForce(new Vector2(-HorizontalAcceleration, 0));
			}
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			if(rigid2D.velocity.x < HorizontalSpeed)
			{
				rigid2D.AddForce(new Vector2(HorizontalAcceleration, 0));
			}
		}
	}
}
