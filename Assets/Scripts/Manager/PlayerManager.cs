using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;
	private CollisionState collisionState;
	private Duck duckBehavior;

	void Awake()
	{
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
		collisionState = GetComponent<CollisionState> ();
		duckBehavior = GetComponent<Duck> ();
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

		animator.speed = walkBehavior.running ? walkBehavior.sprintMultiplier*0.5f : 0.5f;

		if (duckBehavior.ducking)
		{
			ChangeAnimationState(3);
		}

		if(!collisionState.standing && collisionState.onWall)
		{
			ChangeAnimationState(4);
		}
	}

	void ChangeAnimationState(int value)
	{
		animator.SetInteger ("AnimState", value);
	}
}
