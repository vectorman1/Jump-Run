using UnityEngine;
using System.Collections;

public class MainMenuButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LoadTutorial()
    {
        Application.LoadLevel("tutorial-level");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadLevel_1()
    {
        Application.LoadLevel("second-level");
    }
    public void LoadLevelSelect()
    {
        Application.LoadLevel("level-select");
    }
}
