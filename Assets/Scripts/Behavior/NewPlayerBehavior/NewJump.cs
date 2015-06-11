using UnityEngine;
using System.Collections;

public class NewJump : AbstractBehavior 
{
	public float jumpSpeed = 200f;
	
	void Update () 
	{
		var canJump = inputState.GetButtonValue (inputButtons [0]);
		var holdTime = inputState.GetButtonHoldTime (inputButtons [0]);
		
		if (collisionState.standing) 
		{
			if(canJump && holdTime < .1f)
			{
				OnJump();
			}
		}
	}
	
	protected virtual void OnJump()
	{
		var vel = body2d.velocity;
		
		body2d.velocity = new Vector2 (vel.x, jumpSpeed);
	}
	
}
