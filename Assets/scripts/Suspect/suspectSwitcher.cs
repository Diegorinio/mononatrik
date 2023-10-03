using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspectSwitcher : MonoBehaviour
{
    public GameObject MainManager;
    public mainSuspectManager manager;
    public AudioSource audioSource;
    public AudioClip switchSound;
    public GameObject fadePanel;
    public int inc;
    int actualID;
    private void Start()
    {
        manager = MainManager.GetComponent<mainSuspectManager>();
        audioSource = GetComponent<AudioSource>();
        actualID = manager.actualSuspectID;
    }

    private void OnMouseDown()
    {
        actualID = manager.actualSuspectID;
        audioSource.Play();
        StartCoroutine(Fade());
        if (inc < 0)
        {
            if (actualID == 0)
            {
                manager.ChangeActualSuspect(2);
            }
            else
            {
                manager.ChangeActualSuspect(actualID - 1);
            }
        }
        else if (inc > 0)
        {
            if (actualID == 2)
            {
                manager.ChangeActualSuspect(0);
            }
            else
            {
                manager.ChangeActualSuspect(actualID + 1);
            }
        }
        actualID = manager.actualSuspectID;
        if(GameObject.FindGameObjectWithTag("Finish")){
            GameObject.FindGameObjectWithTag("Finish").SetActive(false);
        }
    }

    IEnumerator Fade()
    {
        fadePanel.SetActive(true);
        yield return new WaitForSeconds(audioSource.clip.length);
        fadePanel.SetActive(false);
    }
}
