using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspectSelector : MonoBehaviour
{
    public GameObject MainManager;
    private mainSuspectManager manager;
    private int actualID;
    public GameObject susSelector;
    bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {
        manager = MainManager.GetComponent<mainSuspectManager>();
        actualID = manager.actualSuspectID;
    }

    private void OnMouseDown()
    {
        actualID = manager.actualSuspectID;
        isActive = susSelector.activeInHierarchy;
        if (!isActive)
        {
            susSelector.SetActive(true);
            isActive = true;
        }
        else {
            susSelector.SetActive(false);
            isActive = false;
        }
        suspectEndingMainScript.selectedSuspect = actualID;
        suspectEndingMainScript.SuspectName = manager.nameSurname.text;
    }
}
