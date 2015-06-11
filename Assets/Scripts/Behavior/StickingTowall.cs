using UnityEngine;
using System.Collections;

public class StickingTowall : AbstractBehavior {

	public bool onWallDetected;

	protected float defaultGravityScale;
	protected float defaultDrag;

	void Start () 
	{
		defaultGravityScale = body2d.gravityScale;
		defaultDrag = body2d.drag;
	}
	
	// Update is called once per frame
	protected virtual void Update ()
	{
		if (collisionState.onWall)
		{
			if(!onWallDetected)
			{
				OnSlide();
				ToggleScripts(false);
				onWallDetected = true;
			}
		} else
		{
			if(onWallDetected)
			{
				OffWall();
				ToggleScripts(true);
				onWallDetected = false;
			}
		}
	}

	protected virtual void OnSlide()
	{
		if (!collisionState.standing && body2d.velocity.y >= 0) 
		{
			body2d.gravityScale = 0;
			body2d.drag = 100; 
		}
	}

	protected virtual void OffWall()
	{
		if (body2d.gravityScale != defaultGravityScale) 
		{
			body2d.gravityScale = defaultGravityScale;
			body2d.drag = defaultDrag;
		}
	}
}
