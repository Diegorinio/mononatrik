using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class introPlayer : MonoBehaviour
{
    public float[] timers;
    public Sprite[] images;
    public GameObject[] framesFragments;
    public float[] perFramesFragments;
    float time;
    Image actImage;
    float len;
    // Start is called before the first frame update
    void Start()
    {
        actImage = GetComponent<Image>();

        len = GetComponent<AudioSource>().clip.length;
        StartCoroutine(Poczekaj());
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        if (time >= timers[0] && time < timers[1])
        {
            actImage.sprite = images[0];
            if (time>= perFramesFragments[0])
            {
                framesFragments[0].SetActive(false);
            }
            if (time >= perFramesFragments[1])
                    {
                framesFragments[1].SetActive(false);
            }
        }
        else if (time > timers[1] && time < timers[2])
            actImage.sprite = images[1];
        else if (time > timers[2])
            actImage.sprite = images[2];

    }
    IEnumerator Poczekaj()
    {
        yield return new WaitForSeconds((float)len);
        SceneManager.LoadScene("day1", LoadSceneMode.Single);
    }
}
