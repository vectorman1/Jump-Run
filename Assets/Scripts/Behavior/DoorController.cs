using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

    Vector3 position;

    public AudioClip door;

    AudioSource doorAudio;
	// Use this for initialization
    void Start()
    {
        doorAudio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.x > 230 && this.gameObject.transform.position.x < 365 && Input.GetKeyDown("return"))
        {
            Application.LoadLevel("tutorial-level");
            doorAudio.PlayOneShot(door);
        }
        if(this.gameObject.transform.position.x > 890 && this.gameObject.transform.position.x < 1025 && Input.GetKeyDown("return"))
        {
            Application.LoadLevel("second-level");
            doorAudio.PlayOneShot(door);
        }
	}
}
