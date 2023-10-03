using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class textUnderlineSlider : MonoBehaviour
{
    GameObject sliderObject;
    Slider slider;
    AudioSource audioSrc;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        sliderObject = gameObject.transform.GetChild(0).gameObject;
        slider = sliderObject.GetComponent<Slider>();
        sliderObject.SetActive(false);
    }
    private void OnMouseOver()
    {
        if(!sliderObject.activeInHierarchy){
            sliderObject.SetActive(true);
        }
        slider.value += Time.deltaTime;
    }

    private void OnMouseEnter()
    {
        audioSrc.Play();
    }

    private void OnMouseExit()
    {
        slider.value = 0;
        sliderObject.SetActive(false);
    }
}