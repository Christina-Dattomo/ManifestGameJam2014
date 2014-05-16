using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public CameraLock camera;
	public Rigidbody2D rigid2D = null;
	public float MaxVelocityX = 6.0f;
	public float AccelerationX = 12.0f;
	public float FlapForce = 1.5f;
	public float GlideGravity = 0.1f;
	public int GlideDuration = 3;
	public float GlideCooldown = 0.5f;
	private float m_normalGravity = 1;
	private float m_glideCooldown;
	private float m_glideDuration;
	public GameObject ParachutePrefab;

	public bool GlideEnabled = true;
	public bool FlightEnabled = true;
	public bool InputEnabled = true;

	public AudioSource playerAudio;
	public AudioClip playerExplosion;
	
	void Start () {
		playerAudio = GameObject.Find("SFXPlayer").GetComponent<AudioSource>();
		m_normalGravity = rigid2D.gravityScale;
		camera = GameObject.Find("Main Camera").GetComponent<CameraLock>();
	}

	void FixedUpdate () 
	{
		//Movement 
		if(FlightEnabled && rigid2D.velocity.x < MaxVelocityX)
			rigid2D.AddForce(new Vector2(AccelerationX, 0));

		if(InputEnabled && m_glideCooldown < 0)
			if(Input.GetKeyDown(KeyCode.UpArrow))
				Glide();
				
		if(GlideEnabled && m_glideDuration > 0)
		{
			rigid2D.gravityScale = GlideGravity;
			m_glideDuration--;
		}
		else
			rigid2D.gravityScale = m_normalGravity; 

		if(m_glideCooldown >= -1)
			m_glideCooldown--;
	}

	void Glide()
	{
		rigid2D.velocity = new Vector2(rigid2D.velocity.x, FlapForce);
		m_glideDuration = GlideDuration*60;
		m_glideCooldown = GlideCooldown*60;
	}
	void OnTriggerEnter2D(Collider2D zone)
	{
		if(zone.CompareTag("AntiGlide"))
			GlideEnabled = false;
		if(zone.CompareTag("AntiInput"))
			InputEnabled = false;
		if(zone.CompareTag("AntiFlight"))
		{
			FlightEnabled = false;
			InputEnabled = false;
			GlideEnabled = false;
		}
		if(zone.CompareTag("CameraExpand"))
		{
			camera.StartExpand();
		}
		if(zone.CompareTag("LevelEnd"))
			CreateParachute();

	}
	void OnTriggerExit2D(Collider2D zone)
	{
		if(zone.CompareTag("AntiGlide"))
			GlideEnabled = true;
		if(zone.CompareTag("AntiInput"))
			InputEnabled = true;
	}
	void CreateParachute()
	{
		playerAudio.PlayOneShot(playerExplosion);
		if(!playerAudio.isPlaying)
		{
			GameObject parachute = (GameObject)Instantiate (ParachutePrefab, transform.position, Quaternion.identity);
			Destroy (this.gameObject);
		}
			//parachute.GetComponent<ParachuteMovement>().rigid2D.velocity = rigid2D.velocity; 

	}
}
