using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspect:Isuspects
{
    string Name;
    string description;
    string hair_color;
    string nationality;
    string residence;
    string id_exp_date;
    string Age;
    public Suspect(string name, string hairs, string age, string nationality, string description,string residence, string ip_exp_date)
    {
        this.Name = name;
        this.hair_color = hairs;
        this.nationality = nationality;
        this.Age = age;
        this.description = description;
        this.residence = residence;
        this.id_exp_date = ip_exp_date;
    }
    public string GetName()
    {
        return this.Name;
    }
    public string GetDescription()
    {
        return this.description;
    }
    public string GetHairColor()
    {
        return this.hair_color;
    }
    public string GetNationality()
    {
        return this.nationality;
    }
    public string GetAge()
    {
        return this.Age;
    }

    public string GetExpDate()
    {
        return this.id_exp_date;
    }
    public string GetResidence()
    {
        return this.residence;
    }

    public string GetEyesColor(){
        return "";
    }
}
