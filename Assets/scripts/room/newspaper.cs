using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspaper : MonoBehaviour
{
    public GameObject newspaperPanel;
    // Start is called before the first frame update
    void Start()
    {
        newspaperPanel.SetActive(true);
    }

    private void OnMouseDown()
    {
        if(!newspaperPanel.activeInHierarchy)
        {
            GetComponent<AudioSource>().Play();
            newspaperPanel.SetActive(true);
        }
        else
        {
            newspaperPanel.SetActive(false);
        }
    }
}
