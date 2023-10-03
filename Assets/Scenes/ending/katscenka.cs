using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class katscenka : MonoBehaviour
{
    float audioLen;
    // Start is called before the first frame update
    void Start()
    {
        audioLen = GetComponent<AudioSource>().clip.length;
        StartCoroutine(wait(audioLen));
    }

    IEnumerator wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime+1);
        SceneManager.LoadScene("credits");
    }
}
