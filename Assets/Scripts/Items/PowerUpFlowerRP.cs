using UnityEngine;
using System.Collections;

public class PowerUpFlowerRP : Colectable {

	public int itemId = 1;
	public GameObject projectilePrefab;

	override protected void OnCollect(GameObject target)
	{
		var equipBehavior = target.GetComponent<Equip> ();
		if (equipBehavior != null)
		{
			equipBehavior.currentItem = itemId;
		}
		var shootBehavior = target.GetComponent<FireProjectile> ();
		if (shootBehavior != null)
		{
			shootBehavior.projectilePrefab = projectilePrefab;
		}

	}
}
