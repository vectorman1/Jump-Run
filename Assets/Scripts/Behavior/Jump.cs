using UnityEngine;
using System.Collections;

public class Jump : AbstractBehavior 
{
	public float jumpSpeed = 200f;
	public float jumpDelay = .1f;
	public int jumpCount = 2;
	public GameObject dustEffectPrefab;

	protected float lastJumpTime = 0;
	protected int jumpsRemaining = 0;

    public AudioClip jump;
    public AudioClip doubleJump;

    AudioSource doubleJumpAudio;
    AudioSource jumpAudio;

    void Start()
    {
        jumpAudio = GetComponent<AudioSource>();
        doubleJumpAudio = GetComponent<AudioSource>();
    }

	void Update () 
	{
		var canJump = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);

		if (collisionState.standing) 
		{
			if (canJump && holdTime < .1f) {
				jumpsRemaining = jumpCount - 1;
				OnJump ();
			}

		} else 
		{
			if(canJump && holdTime < .1f && Time.time - lastJumpTime > jumpDelay)
			{
				if(jumpsRemaining >0)
				{
					OnJump();
					jumpsRemaining --;
					var clone = Instantiate(dustEffectPrefab);
					clone.transform.position = transform.position;
                    doubleJumpAudio.PlayOneShot(doubleJump);
				}
			}
		}
	}

	protected virtual void OnJump()
	{
        
		var vel = body2d.velocity;
		lastJumpTime = Time.time;
		body2d.velocity = new Vector2 (vel.x, jumpSpeed);
	}

}
