using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class MainSuspectManager : MonoBehaviour
{
    Suspect[] suspects = new Suspect[3];
    public Text nameSurname;
    public Text hairColor;
    public Text age;
    public Text nationality;
    public Text suspectDescription;
    public Text residence;
    public Text idExpDate;
    public Suspect ActualSuspect;
    public GameObject suspectImage;
    public Sprite[] susImages;
    public Sprite[] susIDimages;
    public Image susIDPlace;
    public int actualSuspectID;
    public int wantedSuspectID;

    void Start()
    {

        suspects = GetComponent<generateSuspect>().GetSuspects();
        Debug.Log(suspects[0]);
        ActualSuspect = suspects[0];
        actualSuspectID = 0;
        FillSuspectInfo(actualSuspectID);
        SuspectEndingMainScript.wantedSuspectId = wantedSuspectID;
    }

    public void FillSuspectInfo(int id)
    {
        ActualSuspect = suspects[id];
        nameSurname.text = ActualSuspect.GetName();
        hairColor.text = ActualSuspect.GetHairColor();
        age.text = ActualSuspect.GetAge().ToString();
        nationality.text = ActualSuspect.GetNationality();
        suspectDescription.text = ActualSuspect.GetDescription();
        residence.text = ActualSuspect.GetResidence();
        idExpDate.text = ActualSuspect.GetExpDate();
        actualSuspectID = id;
        susIDPlace.sprite = susIDimages[actualSuspectID];
        suspectImage.GetComponent<Image>().sprite = susImages[actualSuspectID];
    }

    public void ChangeActualSuspect(int id)
    {
        ActualSuspect = suspects[id];
        actualSuspectID = id;
        FillSuspectInfo(actualSuspectID);
    }
}
