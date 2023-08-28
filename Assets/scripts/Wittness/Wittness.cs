using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wittness: Isuspects
{
    string hair_color;
    string eyes_color;
    string age;
    string description;
    public Wittness(string h_color,string e_color, string age, string description)
    {
        this.hair_color = h_color;
        this.eyes_color = e_color;
        this.age = age;
        this.description = description;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public string GetHairColor()
    {
        return this.hair_color;
    }
    public string GetEyesColor()
    {
        return this.eyes_color;
    }
    public string GetAge()
    {
        return age;
    }
}
