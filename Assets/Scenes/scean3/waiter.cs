using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class waiter : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<AudioSource>().clip.length;
        StartCoroutine(Poczekaj(time + 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Poczekaj(float t)
    {
        yield return new WaitForSeconds(t);
        SceneManager.LoadScene("Day3");
    }
}
