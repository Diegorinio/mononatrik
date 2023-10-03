using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class suspectEndingMainScript : MonoBehaviour
{
    public static int day;
    public static int correct;
    public static int selectedSuspect;
    public static int wantedSuspectId;
    public static string SuspectName;
    public static void reset(){
        day=0;
        correct=0;
    }
}
