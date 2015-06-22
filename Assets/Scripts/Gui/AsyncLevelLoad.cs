using UnityEngine;
using System.Collections;
public class AsyncLevelLoad : MonoBehaviour {

    
	// Use this for initialization
    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAsync("tutorial-level");
        yield return async;
        async = Application.LoadLevelAsync("splash-screen");
        yield return async;
        async = Application.LoadLevelAsync("level-select");
        yield return async;
        async = Application.LoadLevelAsync("second-level");
        yield return async;
        async = Application.LoadLevelAsync("main-menu");
        Debug.Log("Loading complete");
    }
	
	// Update is called once per frame
	void Update () {
	    if (Application.GetStreamProgressForLevel("tutorial-level") == 1 &&
            Application.GetStreamProgressForLevel("second-level") == 1 &&
            Application.GetStreamProgressForLevel("main-menu") == 1 &&
            Application.GetStreamProgressForLevel("splash-screen") == 1 &&
            Application.GetStreamProgressForLevel("level-select") == 1)
        {
            Application.LoadLevel("splash-screen");
        }
	}
}
