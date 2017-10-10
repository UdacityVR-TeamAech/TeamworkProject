using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusic : MonoBehaviour {

    public void ChangeAmbientAudioClip(AudioClip audioClip){
    
        AudioSource ambientMusic = this.GetComponent<AudioSource>();

        ambientMusic.clip = audioClip;
        ambientMusic.Play();
    } 

}
