using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowText : MonoBehaviour 
{
	public Text referenceToText;
	public string targetTag = "Player";
	public string text;

    bool showed = false;
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.gameObject.tag == targetTag && !showed) 
		{
			referenceToText.text = text;
            showed = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D target)
	{
		if (target.gameObject.tag == targetTag && showed) 
		{	
			referenceToText.text = "";
		}
	}
}
