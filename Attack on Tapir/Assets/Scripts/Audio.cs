using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

    public AudioClip music;
    //AudioSource audio;

    // Use this for initialization
    void Start () {
        GetComponent<AudioSource>().PlayOneShot(music, 0.7f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
