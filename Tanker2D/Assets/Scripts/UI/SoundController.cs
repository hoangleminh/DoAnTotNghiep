using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayEffect(AudioClip effectsound)
    {
        GameObject playEffectObj = new GameObject();
        playEffectObj.AddComponent<AudioSource>();
        AudioSource audiosource = playEffectObj.GetComponent<AudioSource>();
        audiosource.PlayOneShot(effectsound);
        Destroy(playEffectObj, effectsound.length);
    }
}
