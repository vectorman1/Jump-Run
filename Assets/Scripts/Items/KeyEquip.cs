using UnityEngine;
using System.Collections;

public class KeyEquip : MonoBehaviour {

	public string keyEquiped;
	public GameObject gameObjectToDestroy;
	void OnCollisionEnter2D(Collision2D target)
	{
		Debug.Log(target.gameObject.tag);
		if (target.gameObject.tag == keyEquiped)
		{

			gameObjectToDestroy = GameObject.FindGameObjectWithTag (keyEquiped);
			Destroy(gameObjectToDestroy);
			keyEquiped = "";
		}
	}
}
