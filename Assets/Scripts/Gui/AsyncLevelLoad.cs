using UnityEngine;
using System.Collections;
public class AsyncLevelLoad : MonoBehaviour {

    
	// Use this for initialization
    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAsync("tutorial-level");
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
            Application.GetStreamProgressForLevel("main-menu") == 1)
        {
            Application.LoadLevel("main-menu");
        }
        Debug.Log(Application.GetStreamProgressForLevel("tutorial-level"));

	}
}
