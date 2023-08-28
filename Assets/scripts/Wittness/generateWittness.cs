using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class generateWittness : MonoBehaviour
{
    public string hair_color;
    public string eyes_color;
    public string age;
    public string description;
    public Text hairColor;
    public Text eyesColor;
    public Text year;
    public Text descriptionTxt;
    void Start()
    {
        Wittness sus = new Wittness(this.hair_color,this.eyes_color, this.age,this.description);
        hairColor.text = sus.GetHairColor();
        eyesColor.text = sus.GetEyesColor();
        year.text = sus.GetAge().ToString();
        descriptionTxt.text = sus.GetDescription();
    }

}
