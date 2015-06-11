using UnityEngine;
using System.Collections;

public class DustEffect : MonoBehaviour {

	// Use this for initialization
	void OnDestroy()
	{
		Destroy (gameObject);
	}
}
