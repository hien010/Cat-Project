using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {
    AudioClip musicClip;
    AudioSource musicSource;

	void Start () {
        musicSource.clip = musicClip;
	}
	

	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            musicSource.Play();
        }
	}
}
