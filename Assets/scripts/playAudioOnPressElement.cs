using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnPressElement : MonoBehaviour
{
    public AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audioSrc.Play();
    }
}
