using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishDayState : MonoBehaviour
{
    public Text stateText;
    public Text personText;
    public Text dayNumber;
    public goToScene scener;
    // Start is called before the first frame update
    void Start()
    {

        int day = suspectEndingMainScript.day;
        if (suspectEndingMainScript.selectedSuspect == suspectEndingMainScript.wantedSuspectId)
        {
            Debug.Log("Win");
            stateText.text = "Criminal is in custody";
            suspectEndingMainScript.correct += 1;
        }
        else
        {
            Debug.Log("Lose");
            stateText.text = "Criminal is still free";
        }
        Debug.Log($"Correct: {suspectEndingMainScript.correct}");
        personText.text = $"{suspectEndingMainScript.SuspectName} gets some taste of justice";
        switch (day)
        {
            case 0:
                day = 1;
                scener.sceneID = "day2";
                break;
            case 1:
                day = 2;
                scener.sceneID = "cut3";
                break;
            case 2:
                day = 3;
                Debug.Log(suspectEndingMainScript.correct);
                if (suspectEndingMainScript.correct >= 2)
                {
                    scener.sceneID = "ending";
                    Debug.Log("Good ending");
                }
                else
                {
                    scener.sceneID = "bad_ending";
                    Debug.Log("Bad ending");
                }
                break;
        }
        suspectEndingMainScript.day = day;
        dayNumber.text = $"Day {suspectEndingMainScript.day.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
