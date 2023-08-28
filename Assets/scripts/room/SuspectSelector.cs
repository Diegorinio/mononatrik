using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectSelector : MonoBehaviour
{
    public GameObject MainManager;
    private MainSuspectManager manager;
    private int actualID;
    public GameObject susSelector;
    bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        manager = MainManager.GetComponent<MainSuspectManager>();
        actualID = manager.actualSuspectID;
    }

    private void OnMouseDown()
    {
        actualID = manager.actualSuspectID;
        isActive = susSelector.active;
        if (!isActive)
        {
            susSelector.SetActive(true);
            isActive = true;
        }
        else {
            susSelector.SetActive(false);
            isActive = false;
        }
        SuspectEndingMainScript.selectedSuspect = actualID;
        SuspectEndingMainScript.SuspectName = manager.nameSurname.text;
    }
}
