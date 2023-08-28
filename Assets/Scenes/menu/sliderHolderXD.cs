using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sliderHolderXD : MonoBehaviour
{
    public Slider slider;
    AudioSource audioSrc;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }
    private void OnMouseOver()
    {
        slider.value += Time.deltaTime;
    }

    private void OnMouseEnter()
    {
        audioSrc.Play();
    }

    private void OnMouseExit()
    {
        slider.value = 0;
    }
}