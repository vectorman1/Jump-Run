using UnityEngine;
using System.Collections;

public class NewWalk : AbstractBehavior 
{
	
	public float speed = 45f;
	public float sprintMultiplier = 1.5f;
	public bool running = false;
	
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		running = false;
		
		var right = inputState.GetButtonValue (inputButtons [0]);
		var left = inputState.GetButtonValue (inputButtons [1]);
		var run = inputState.GetButtonValue (inputButtons [2]);
		if (right || left) 
		{
			var tmpSpeed = speed;
			
			if(run && sprintMultiplier > 0)
			{
				tmpSpeed *= sprintMultiplier;
				running = true;
			}
			
			var velX = tmpSpeed * (float)inputState.direction;
			
			body2d.velocity = new Vector2(velX, body2d.velocity.y);
		}
	}
}
