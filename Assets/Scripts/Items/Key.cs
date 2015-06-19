using UnityEngine;
using System.Collections;

public class Key : Colectable {

	public string keyID;
	
	override protected void OnCollect(GameObject target)
	{
		var keyBehavior = target.GetComponent<KeyEquip> ();
		keyBehavior.keyEquiped = keyID;
			
	}
}
