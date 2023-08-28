using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public GameObject newspaperPanel;
    // Start is called before the first frame update
    void Start()
    {
        newspaperPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(!newspaperPanel.active)
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
