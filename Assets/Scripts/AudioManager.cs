using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource walkmanAudioPlayer;
    public List<AudioClip> talking = new List<AudioClip>();
    public List<AudioClip> music = new List<AudioClip>();
    private int currentSong;

    void Start(){
        walkmanAudioPlayer = GameObject.Find("walkman").GetComponent<AudioSource>();
        currentSong = Random.Range(0,music.Count-1);
    }

    public void setAudio(int whoTalks){
        if (whoTalks != -1){//If i'm talking, do this
            walkmanAudioPlayer.clip = talking[whoTalks];
            walkmanAudioPlayer.volume = 0.5f;
        }else{ //if I am not talking, then play a random song 
            if (currentSong == music.Count-1){
                currentSong = 0;
            } else {
                currentSong++;
            }
            walkmanAudioPlayer.clip = music[currentSong];
            walkmanAudioPlayer.volume = 0.3f;

        }
       
    }
}
