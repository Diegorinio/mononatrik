using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class introScript : MonoBehaviour
{
    public VideoClip clip;
    double len;
    // Start is called before the first frame update
    void Start()
    {
        len = clip.length+1.0;
        StartCoroutine(PoczekajKurwa());
    }

    IEnumerator PoczekajKurwa()
    {
        yield return new WaitForSeconds((float)len);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
