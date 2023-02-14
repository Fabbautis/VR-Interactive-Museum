using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioManager audioManager;
    private AudioSource audioSource;
    bool canPlay;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        audioManager = gameObject.GetComponent<AudioManager>();
    }

    public void PlayMusic(){
        if(canPlay){
            audioSource.Play();
        }
    }
    
    public void StopSound(){
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            canPlay = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            canPlay = false;
        }
    }
}
