using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour
{

	private InputState inputState;
	private Walk walkBehavior;
	private Animator animator;

	void Awake()
	{
		inputState = GetComponent<InputState> ();
		walkBehavior = GetComponent<Walk> ();
		animator = GetComponent<Animator> ();
	}


	// Update is called once per frame
	void Update ()
	{
		if (inputState.absVelX == 0) 
		{
			ChangeAnimationState(0);
		}

		if (inputState.absVelX > 0) 
		{
			ChangeAnimationState(1);
		}

		animator.speed = walkBehavior.running ? walkBehavior.runMultiplier*0.5f : 0.5f;
	}

	void ChangeAnimationState(int value)
	{
		animator.SetInteger ("AnimState", value);
	}
}
