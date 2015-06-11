using UnityEngine;
using System.Collections;

public class Equip : AbstractBehavior {

	private int _currentItem = 0;
	private Animator animator;

	public int currentItem
	{
		get{ return _currentItem;}
		set
		{
			_currentItem = value;
			animator.SetInteger("EquipItem", _currentItem);
		}
	}
	override protected void Awake()
	{
		base.Awake ();
		animator = GetComponent<Animator> ();
	}
}
