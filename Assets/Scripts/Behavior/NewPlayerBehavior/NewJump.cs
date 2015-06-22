using UnityEngine;
using System.Collections;

public class NewJump : AbstractBehavior 
{
	public float jumpSpeed = 200f;
	public float longJumpDeleay = 0.15f;
	public float longJumpMultiplier = 1.5f;
	public bool canLongJump;
	public bool isLongJumping;
    
    public AudioClip jump;

    AudioSource jumpSource;

    void Start()
    {
        jumpSource = GetComponent<AudioSource>();
    }

	void Update () 
	{
		var canJump = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);

		if (!canJump)
		{
			canLongJump = false;
		}
		if (collisionState.standing && isLongJumping) 
		{
			isLongJumping = false;
		}
		if (collisionState.standing) 
		{
			if(canJump && holdTime < .1f)
			{
				OnJump();
			}
		}
		if(canLongJump && !collisionState.standing && holdTime > longJumpDeleay)
		{
			var vel = body2d.velocity;
			body2d.velocity = new Vector2 (vel.x, jumpSpeed* longJumpMultiplier);
			isLongJumping = true;
			canLongJump = false;
            
		}
	}
	
	protected virtual void OnJump()
	{
		var vel = body2d.velocity;
        jumpSource.PlayOneShot(jump);
		body2d.velocity = new Vector2 (vel.x, jumpSpeed);
		canLongJump = true;
	}
	
}
