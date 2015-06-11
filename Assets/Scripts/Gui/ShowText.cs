using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowText : MonoBehaviour 
{
	public Text referenceToText;
	public string targetTag = "Player";
	public string text;

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.gameObject.tag == targetTag) 
		{
			referenceToText.text = text;
		}
	}
	
	void OnTriggerExit2D(Collider2D target)
	{
		if (target.gameObject.tag == targetTag) 
		{	
			referenceToText.text = "";
		}
	}
}
