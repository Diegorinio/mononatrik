using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateSuspect : MonoBehaviour
{
    Suspect[] suspects = new Suspect[3];
    public string[] names = new string[3];
    public string[] hairs_colors = new string[3];
    public string[] ages = new string[3];
    public string[] nationality = new string[3];
    public string[] descriptions = new string[3];
    public string[] residence = new string[3];
    public string[] exp_dates = new string[3];
    // Start is called before the first frame update
    void Awake()
    {
        suspects[0] = new Suspect(names[0], hairs_colors[0], ages[0], nationality[0], descriptions[0], residence[0], exp_dates[0]);
        suspects[1] = new Suspect(names[1], hairs_colors[1], ages[1], nationality[1], descriptions[1], residence[1], exp_dates[1]);
        suspects[2] = new Suspect(names[2], hairs_colors[2], ages[2], nationality[2], descriptions[2], residence[2], exp_dates[2]);
    }
    public Suspect[] GetSuspects()
    {
        return suspects;
    }
}
