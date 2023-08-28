using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class suspectAnim : MonoBehaviour
{
    public float rnd_duration;
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        rnd_duration = Random.Range(1,10);
        yield return new WaitForSeconds(rnd_duration);
        GetComponent<Image>().transform.localScale = new Vector3(transform.localScale.x*(-1), transform.localScale.y, transform.localScale.z);
        StartCoroutine(Wait());
    }
}
