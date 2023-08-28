using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SuspectEndingMainScript.day = 0;
        SuspectEndingMainScript.correct = 0;
    }
}
