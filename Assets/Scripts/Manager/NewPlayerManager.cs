using UnityEngine;
using System.Collections;

public class NewPlayerManager : MonoBehaviour
{
	
	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;
	
	void Awake()
	{
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		if (collisionState.standing) 
		{
			ChangeAnimationState(0);
		}
		
		if (inputState.absVelX > 0) 
		{
			ChangeAnimationState(1);
		}
		
		if (inputState.absVelY > 0)
		{
			ChangeAnimationState(2);
		}
		animator.speed = walkBehavior.running ? walkBehavior.sprintMultiplier*4f : 4f;
	}
	
	void ChangeAnimationState(int value)
	{
		animator.SetInteger ("AnimState", value);
	}
}
