using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{
    private int currentID;
    private AudioSource audioSource;
    public AudioClip[] songs;
    public AudioClip OnOff;
    private bool isOn=true;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        shuffleSong();
    }

    private void OnMouseDown()
    {
        if(isOn){
            isOn=false;
            audioSource.clip = OnOff;
            audioSource.Play();
            // audioSource.Stop();
        }
        else{
            isOn=true;
            shuffleSong();   
        }
    }

    private void shuffleSong()
    {
        isOn = true;
        int rnd = Random.Range(0, songs.Length);
        while (rnd == currentID)
        {
            rnd = Random.Range(0, songs.Length);
        }
        audioSource.clip = songs[rnd];
        currentID = rnd;
        audioSource.Play();
    }
}
